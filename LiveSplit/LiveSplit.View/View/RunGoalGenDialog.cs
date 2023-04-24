using System;
using System.Linq;
using System.Windows.Forms;
using LiveSplit.Model;

namespace LiveSplit.View
{
    public partial class RunGoalGenDialog : Form
    {
        private static readonly char[] ALLOWED_CHARS = "\b0123456789:.".ToCharArray();

        private IRun Run { get; set; }
        private TimingMethod SelectedMethod { get; set; }

        private TimeSpan SumOfBestSegments { get; set; }
        private TimeSpan GoalTime { get; set; }

        private double Scalar { get; set; }
        private bool InputVerified { get; set; }

        public RunGoalGenDialog( LiveSplitState state ) {
            Run = state.Run;
            SelectedMethod = state.CurrentTimingMethod;

            SumOfBestSegments = TimeSpan.Zero;
            GoalTime = TimeSpan.Zero;
            Scalar = 0.0d;
            InputVerified = false;

            InitializeComponent();
        }

        private void RunGoalGenDialog_Load( object sender, EventArgs e ) {
            SumOfBestSegments = (TimeSpan) SumOfBest.CalculateSumOfBest( Run, true, false, SelectedMethod );

            SoB_digits.Visible = true;

            string thisOutput = SumOfBestSegments.ToString();
            SoB_digits.Text = thisOutput.Substring( 0, 4 + thisOutput.LastIndexOf( '.' ) );
        }

        private void Goal_input_KeyPress( object sender, KeyPressEventArgs e ) {
            if( !ALLOWED_CHARS.Contains( e.KeyChar ) )
                e.Handled = true;
        }

        private void Goal_input_TextChanged( object sender, EventArgs e ) {
            try {
                GoalTime = TimeSpan.Parse( Goal_input.Text );

                Scalar = GoalTime.TotalSeconds / SumOfBestSegments.TotalSeconds;
                InputVerified = true;

                Goal_output.Text = "Scalar: " + ( Scalar.ToString().Length > 7 ? Scalar.ToString().Substring( 0, 7 ) : Scalar.ToString() );
                Goal_output.Visible = true;

            } catch( FormatException ) {
                InputRejected();
            } catch( OverflowException ) {
                InputRejected();
            }
        }

        private void Submit_button_Click( object sender, EventArgs e ) {
            if( !InputVerified ) {
                MessageBox.Show( "Please enter a valid Goal time to generate.", "No valid input data!", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            string listName = "Goal";

            if( Run.Comparisons.Contains( listName ) ) {
                var result = MessageBox.Show( "Would you like to overwrite the existing goal comparison?",
                    "Goal Comparison already exists", MessageBoxButtons.YesNo );
                if( result == DialogResult.No )
                    return;

            } else
                Run.CustomComparisons.Add( listName );

            foreach( var curSplit in Run ) {
                TimeSpan currentGold = (TimeSpan) curSplit.BestSegmentTime[ SelectedMethod ];

                // ! Fails if comparison already exists.
                // TODO: Split into GenerateNew and GenerateOverwrite functions.
                curSplit.Comparisons.Add( listName, new Time( SelectedMethod,
                    (TimeSpan?) TimeSpan.FromMinutes( Scalar * currentGold.TotalMinutes ) ) );
            }

            DialogResult = DialogResult.OK;
        }

        private void InputRejected() {
            GoalTime = TimeSpan.Zero;
            InputVerified = false;
            Goal_output.Text = "Syntax Error";
            Goal_output.Visible = false;
        }

        private void GenerateNew( string title ) {

        }

        private void GenerateOverwrite( string title ) {

        }
    }
}

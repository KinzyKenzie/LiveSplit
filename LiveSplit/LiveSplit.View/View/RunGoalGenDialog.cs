using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.View
{
    public partial class RunGoalGenDialog : Form
    {
        private static readonly char[] ALLOWED_CHARS = "\b0123456789:.".ToCharArray();
        private static readonly string INPUT_TEMPLATE = "00:00:00.000";

        public IRun Run { get; set; }
        public TimeSpan? SumOfBestSegmentsRTA { get; set; }
        public TimeSpan? SumOfBestSegmentsIGT { get; set; }

        private string inputRaw;

        public RunGoalGenDialog( IRun run ) {

            Run = run;
            SumOfBestSegmentsRTA = new TimeSpan?();
            SumOfBestSegmentsIGT = new TimeSpan?();

            InitializeComponent();
        }

        private void RunGoalGenDialog_Load( object sender, EventArgs e ) {

            //TODO
            // 1: Get current Sum of Best
            // 2: Require Goal PB time
            // 3: Calculate scalar
            // 4: Create new Comparison
            // 5: Populate new Comparison

            SumOfBestSegmentsRTA = SumOfBest.CalculateSumOfBest( Run, true, false, TimingMethod.RealTime );
            SumOfBestSegmentsIGT = SumOfBest.CalculateSumOfBest( Run, true, false, TimingMethod.GameTime );

            SoB_digits.Visible = true;
            SoB_digits.Text = INPUT_TEMPLATE;

        }

        private void Goal_input_KeyPress( object sender, KeyPressEventArgs e ) {
            if( !ALLOWED_CHARS.Contains( e.KeyChar ) ) {
                Console.WriteLine( "Blocked user input: " + e.KeyChar );
                e.Handled = true;
            }
        }

        private void Goal_input_TextChanged( object sender, EventArgs e ) {

            //if( Goal_input.Text.Length > 0 && !ALLOWED_CHARS.Contains( Goal_input.Text[ Goal_input.Text.Length - 1 ] ) ) {
            //    Goal_input.Text = Goal_input.Text.Substring( 0, Goal_input.Text.Length - 1 );
            //    //Goal_input.Focus();
            //    Goal_input.Select( Goal_input.Text.Length, 0 );
            //}

            inputRaw = Goal_input.Text;

        }
    }
}

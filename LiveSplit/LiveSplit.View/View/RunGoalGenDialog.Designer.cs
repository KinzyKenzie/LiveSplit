
namespace LiveSplit.View
{
    partial class RunGoalGenDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SoB_label = new System.Windows.Forms.Label();
            this.SoB_digits = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Goal_label = new System.Windows.Forms.Label();
            this.Goal_input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoB_label
            // 
            this.SoB_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SoB_label.AutoSize = true;
            this.SoB_label.Location = new System.Drawing.Point(10, 25);
            this.SoB_label.Name = "SoB_label";
            this.SoB_label.Size = new System.Drawing.Size(114, 13);
            this.SoB_label.TabIndex = 1;
            this.SoB_label.Text = "Sum of Best Segments";
            // 
            // SoB_digits
            // 
            this.SoB_digits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SoB_digits.AutoSize = true;
            this.SoB_digits.Location = new System.Drawing.Point(154, 25);
            this.SoB_digits.Name = "SoB_digits";
            this.SoB_digits.Size = new System.Drawing.Size(67, 13);
            this.SoB_digits.TabIndex = 2;
            this.SoB_digits.Text = "hh:mm:ss.ms";
            this.SoB_digits.Visible = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.SoB_label, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.SoB_digits, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.Goal_label, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.Goal_input, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(496, 217);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // Goal_label
            // 
            this.Goal_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Goal_label.AutoSize = true;
            this.Goal_label.Location = new System.Drawing.Point(10, 75);
            this.Goal_label.Name = "Goal_label";
            this.Goal_label.Size = new System.Drawing.Size(29, 13);
            this.Goal_label.TabIndex = 3;
            this.Goal_label.Text = "Goal";
            // 
            // Goal_input
            // 
            this.Goal_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Goal_input.Location = new System.Drawing.Point(10, 122);
            this.Goal_input.MaxLength = 12;
            this.Goal_input.Name = "Goal_input";
            this.Goal_input.Size = new System.Drawing.Size(138, 20);
            this.Goal_input.TabIndex = 4;
            this.Goal_input.TextChanged += new System.EventHandler(this.Goal_input_TextChanged);
            this.Goal_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Goal_input_KeyPress);
            // 
            // RunGoalGenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunGoalGenDialog";
            this.ShowIcon = false;
            this.Text = "Generate Goal Comparison";
            this.Load += new System.EventHandler(this.RunGoalGenDialog_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SoB_label;
        private System.Windows.Forms.Label SoB_digits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label Goal_label;
        private System.Windows.Forms.TextBox Goal_input;
    }
}
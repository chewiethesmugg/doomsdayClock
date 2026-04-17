namespace Yearlydoom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            progressBar = new ProgressBar();
            lbOutput = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleDescription = "title";
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(165, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Time's Tickin!";
            label1.Click += label1_Click;
            // 
            // progressBar
            // 
            progressBar.AccessibleDescription = "progresbar";
            progressBar.Location = new Point(53, 65);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(365, 23);
            progressBar.TabIndex = 2;
            progressBar.Click += progressBar_Click;
            // 
            // lbOutput
            // 
            lbOutput.Anchor = AnchorStyles.Left;
            lbOutput.AutoSize = true;
            lbOutput.BackColor = Color.Transparent;
            lbOutput.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOutput.ForeColor = Color.OrangeRed;
            lbOutput.Location = new Point(195, 100);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(69, 15);
            lbOutput.TabIndex = 3;
            lbOutput.Text = "Days Left";
            lbOutput.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 185);
            Controls.Add(lbOutput);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar;
        private Label lbOutput;
    }
}

namespace SiwiecDesktopMonitor
{
    partial class Testing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_testing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_testing
            // 
            this.label_testing.AutoSize = true;
            this.label_testing.ForeColor = System.Drawing.Color.Silver;
            this.label_testing.Location = new System.Drawing.Point(215, 119);
            this.label_testing.Name = "label_testing";
            this.label_testing.Size = new System.Drawing.Size(63, 13);
            this.label_testing.TabIndex = 5;
            this.label_testing.Text = "testing label";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 338);
            this.Controls.Add(this.label_testing);
            this.Name = "Testing";
            this.Text = "Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_testing;
    }
}
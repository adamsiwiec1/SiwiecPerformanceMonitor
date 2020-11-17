namespace SiwiecDesktopMonitor
{
    partial class monitor
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
            this.components = new System.ComponentModel.Container();
            this.cpu_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.memory_available = new System.Windows.Forms.Label();
            this.system_uptime = new System.Windows.Forms.Label();
            this.memory_cached = new System.Windows.Forms.Label();
            this.cpu_performance = new System.Windows.Forms.Label();
            this.cpu_thread = new System.Windows.Forms.Label();
            this.cpu_freq = new System.Windows.Forms.Label();
            this.cpu_utility = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpu_time
            // 
            this.cpu_time.AutoSize = true;
            this.cpu_time.ForeColor = System.Drawing.Color.Silver;
            this.cpu_time.Location = new System.Drawing.Point(12, 21);
            this.cpu_time.Name = "cpu_time";
            this.cpu_time.Size = new System.Drawing.Size(91, 13);
            this.cpu_time.TabIndex = 0;
            this.cpu_time.Text = "% Processor Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // memory_available
            // 
            this.memory_available.AutoSize = true;
            this.memory_available.ForeColor = System.Drawing.Color.Silver;
            this.memory_available.Location = new System.Drawing.Point(18, 160);
            this.memory_available.Name = "memory_available";
            this.memory_available.Size = new System.Drawing.Size(113, 13);
            this.memory_available.TabIndex = 1;
            this.memory_available.Text = "Available Memory (mb)";
            // 
            // system_uptime
            // 
            this.system_uptime.AutoSize = true;
            this.system_uptime.ForeColor = System.Drawing.Color.Silver;
            this.system_uptime.Location = new System.Drawing.Point(311, 100);
            this.system_uptime.Name = "system_uptime";
            this.system_uptime.Size = new System.Drawing.Size(78, 13);
            this.system_uptime.TabIndex = 2;
            this.system_uptime.Text = "System up-time";
            // 
            // memory_cached
            // 
            this.memory_cached.AutoSize = true;
            this.memory_cached.ForeColor = System.Drawing.Color.Silver;
            this.memory_cached.Location = new System.Drawing.Point(18, 173);
            this.memory_cached.Name = "memory_cached";
            this.memory_cached.Size = new System.Drawing.Size(107, 13);
            this.memory_cached.TabIndex = 3;
            this.memory_cached.Text = "Cached Memory (mb)";
            // 
            // cpu_performance
            // 
            this.cpu_performance.AutoSize = true;
            this.cpu_performance.ForeColor = System.Drawing.Color.Silver;
            this.cpu_performance.Location = new System.Drawing.Point(12, 100);
            this.cpu_performance.Name = "cpu_performance";
            this.cpu_performance.Size = new System.Drawing.Size(128, 13);
            this.cpu_performance.TabIndex = 4;
            this.cpu_performance.Text = "% Processor Performance";
            // 
            // cpu_thread
            // 
            this.cpu_thread.AutoSize = true;
            this.cpu_thread.ForeColor = System.Drawing.Color.Silver;
            this.cpu_thread.Location = new System.Drawing.Point(311, 49);
            this.cpu_thread.Name = "cpu_thread";
            this.cpu_thread.Size = new System.Drawing.Size(72, 13);
            this.cpu_thread.TabIndex = 5;
            this.cpu_thread.Text = "Thread Count";
            // 
            // cpu_freq
            // 
            this.cpu_freq.AutoSize = true;
            this.cpu_freq.ForeColor = System.Drawing.Color.Silver;
            this.cpu_freq.Location = new System.Drawing.Point(12, 49);
            this.cpu_freq.Name = "cpu_freq";
            this.cpu_freq.Size = new System.Drawing.Size(107, 13);
            this.cpu_freq.TabIndex = 6;
            this.cpu_freq.Text = "Processor Frequency";
            // 
            // cpu_utility
            // 
            this.cpu_utility.AutoSize = true;
            this.cpu_utility.ForeColor = System.Drawing.Color.Silver;
            this.cpu_utility.Location = new System.Drawing.Point(12, 74);
            this.cpu_utility.Name = "cpu_utility";
            this.cpu_utility.Size = new System.Drawing.Size(93, 13);
            this.cpu_utility.TabIndex = 7;
            this.cpu_utility.Text = "% Processor Utility";
            // 
            // monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(545, 273);
            this.Controls.Add(this.cpu_utility);
            this.Controls.Add(this.cpu_freq);
            this.Controls.Add(this.cpu_thread);
            this.Controls.Add(this.cpu_performance);
            this.Controls.Add(this.memory_cached);
            this.Controls.Add(this.system_uptime);
            this.Controls.Add(this.memory_available);
            this.Controls.Add(this.cpu_time);
            this.Name = "monitor";
            this.Text = "Adam\'s Desktop Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpu_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label memory_available;
        private System.Windows.Forms.Label system_uptime;
        private System.Windows.Forms.Label memory_cached;
        private System.Windows.Forms.Label cpu_performance;
        private System.Windows.Forms.Label cpu_thread;
        private System.Windows.Forms.Label cpu_freq;
        private System.Windows.Forms.Label cpu_utility;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monitor));
            this.cpu_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.memory_available = new System.Windows.Forms.Label();
            this.system_uptime = new System.Windows.Forms.Label();
            this.memory_cached = new System.Windows.Forms.Label();
            this.cpu_performance = new System.Windows.Forms.Label();
            this.cpu_thread = new System.Windows.Forms.Label();
            this.cpu_freq = new System.Windows.Forms.Label();
            this.cpu_utility = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_object = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_counter = new System.Windows.Forms.TextBox();
            this.tb_instance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.userinput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpu_time
            // 
            this.cpu_time.AutoSize = true;
            this.cpu_time.ForeColor = System.Drawing.Color.Silver;
            this.cpu_time.Location = new System.Drawing.Point(12, 13);
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
            this.memory_available.Location = new System.Drawing.Point(12, 86);
            this.memory_available.Name = "memory_available";
            this.memory_available.Size = new System.Drawing.Size(113, 13);
            this.memory_available.TabIndex = 1;
            this.memory_available.Text = "Available Memory (mb)";
            // 
            // system_uptime
            // 
            this.system_uptime.AutoSize = true;
            this.system_uptime.ForeColor = System.Drawing.Color.Silver;
            this.system_uptime.Location = new System.Drawing.Point(286, 70);
            this.system_uptime.Name = "system_uptime";
            this.system_uptime.Size = new System.Drawing.Size(78, 13);
            this.system_uptime.TabIndex = 2;
            this.system_uptime.Text = "System up-time";
            // 
            // memory_cached
            // 
            this.memory_cached.AutoSize = true;
            this.memory_cached.ForeColor = System.Drawing.Color.Silver;
            this.memory_cached.Location = new System.Drawing.Point(12, 100);
            this.memory_cached.Name = "memory_cached";
            this.memory_cached.Size = new System.Drawing.Size(107, 13);
            this.memory_cached.TabIndex = 3;
            this.memory_cached.Text = "Cached Memory (mb)";
            // 
            // cpu_performance
            // 
            this.cpu_performance.AutoSize = true;
            this.cpu_performance.ForeColor = System.Drawing.Color.Silver;
            this.cpu_performance.Location = new System.Drawing.Point(12, 52);
            this.cpu_performance.Name = "cpu_performance";
            this.cpu_performance.Size = new System.Drawing.Size(128, 13);
            this.cpu_performance.TabIndex = 4;
            this.cpu_performance.Text = "% Processor Performance";
            // 
            // cpu_thread
            // 
            this.cpu_thread.AutoSize = true;
            this.cpu_thread.ForeColor = System.Drawing.Color.Silver;
            this.cpu_thread.Location = new System.Drawing.Point(286, 26);
            this.cpu_thread.Name = "cpu_thread";
            this.cpu_thread.Size = new System.Drawing.Size(72, 13);
            this.cpu_thread.TabIndex = 5;
            this.cpu_thread.Text = "Thread Count";
            // 
            // cpu_freq
            // 
            this.cpu_freq.AutoSize = true;
            this.cpu_freq.ForeColor = System.Drawing.Color.Silver;
            this.cpu_freq.Location = new System.Drawing.Point(12, 26);
            this.cpu_freq.Name = "cpu_freq";
            this.cpu_freq.Size = new System.Drawing.Size(107, 13);
            this.cpu_freq.TabIndex = 6;
            this.cpu_freq.Text = "Processor Frequency";
            // 
            // cpu_utility
            // 
            this.cpu_utility.AutoSize = true;
            this.cpu_utility.ForeColor = System.Drawing.Color.Silver;
            this.cpu_utility.Location = new System.Drawing.Point(12, 39);
            this.cpu_utility.Name = "cpu_utility";
            this.cpu_utility.Size = new System.Drawing.Size(93, 13);
            this.cpu_utility.TabIndex = 7;
            this.cpu_utility.Text = "% Processor Utility";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(297, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "If system up-time is high, then restart your computer from the start menu.";
            // 
            // tb_object
            // 
            this.tb_object.Location = new System.Drawing.Point(124, 293);
            this.tb_object.Name = "tb_object";
            this.tb_object.Size = new System.Drawing.Size(100, 20);
            this.tb_object.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(132, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Object";
            // 
            // tb_counter
            // 
            this.tb_counter.Location = new System.Drawing.Point(289, 293);
            this.tb_counter.Name = "tb_counter";
            this.tb_counter.Size = new System.Drawing.Size(100, 20);
            this.tb_counter.TabIndex = 11;
            // 
            // tb_instance
            // 
            this.tb_instance.Location = new System.Drawing.Point(472, 293);
            this.tb_instance.Name = "tb_instance";
            this.tb_instance.Size = new System.Drawing.Size(100, 20);
            this.tb_instance.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(286, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Counter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(469, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Instance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(66, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(538, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Counter List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(300, 330);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 18;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // userinput
            // 
            this.userinput.AutoSize = true;
            this.userinput.ForeColor = System.Drawing.Color.Silver;
            this.userinput.Location = new System.Drawing.Point(66, 175);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(68, 13);
            this.userinput.TabIndex = 20;
            this.userinput.Text = "Your counter";
            // 
            // monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(696, 377);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_instance);
            this.Controls.Add(this.tb_counter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_object);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_object;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_counter;
        private System.Windows.Forms.TextBox tb_instance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userinput;
    }
}


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
            this.network_packet = new System.Windows.Forms.Label();
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
            this.network_packetrecieved = new System.Windows.Forms.Label();
            this.network_packetsent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpu_time
            // 
            this.cpu_time.AutoSize = true;
            this.cpu_time.ForeColor = System.Drawing.Color.Silver;
            this.cpu_time.Location = new System.Drawing.Point(12, 26);
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
            this.memory_available.Location = new System.Drawing.Point(188, 23);
            this.memory_available.Name = "memory_available";
            this.memory_available.Size = new System.Drawing.Size(113, 13);
            this.memory_available.TabIndex = 1;
            this.memory_available.Text = "Available Memory (mb)";
            // 
            // system_uptime
            // 
            this.system_uptime.AutoSize = true;
            this.system_uptime.ForeColor = System.Drawing.Color.Silver;
            this.system_uptime.Location = new System.Drawing.Point(509, 22);
            this.system_uptime.Name = "system_uptime";
            this.system_uptime.Size = new System.Drawing.Size(78, 13);
            this.system_uptime.TabIndex = 2;
            this.system_uptime.Text = "System up-time";
            // 
            // memory_cached
            // 
            this.memory_cached.AutoSize = true;
            this.memory_cached.ForeColor = System.Drawing.Color.Silver;
            this.memory_cached.Location = new System.Drawing.Point(188, 36);
            this.memory_cached.Name = "memory_cached";
            this.memory_cached.Size = new System.Drawing.Size(107, 13);
            this.memory_cached.TabIndex = 3;
            this.memory_cached.Text = "Cached Memory (mb)";
            // 
            // cpu_performance
            // 
            this.cpu_performance.AutoSize = true;
            this.cpu_performance.ForeColor = System.Drawing.Color.Silver;
            this.cpu_performance.Location = new System.Drawing.Point(12, 65);
            this.cpu_performance.Name = "cpu_performance";
            this.cpu_performance.Size = new System.Drawing.Size(128, 13);
            this.cpu_performance.TabIndex = 4;
            this.cpu_performance.Text = "% Processor Performance";
            // 
            // network_packet
            // 
            this.network_packet.AutoSize = true;
            this.network_packet.ForeColor = System.Drawing.Color.Silver;
            this.network_packet.Location = new System.Drawing.Point(373, 22);
            this.network_packet.Name = "network_packet";
            this.network_packet.Size = new System.Drawing.Size(68, 13);
            this.network_packet.TabIndex = 5;
            this.network_packet.Text = "Packets/sec";
            // 
            // cpu_freq
            // 
            this.cpu_freq.AutoSize = true;
            this.cpu_freq.ForeColor = System.Drawing.Color.Silver;
            this.cpu_freq.Location = new System.Drawing.Point(12, 39);
            this.cpu_freq.Name = "cpu_freq";
            this.cpu_freq.Size = new System.Drawing.Size(107, 13);
            this.cpu_freq.TabIndex = 6;
            this.cpu_freq.Text = "Processor Frequency";
            // 
            // cpu_utility
            // 
            this.cpu_utility.AutoSize = true;
            this.cpu_utility.ForeColor = System.Drawing.Color.Silver;
            this.cpu_utility.Location = new System.Drawing.Point(12, 52);
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
            this.label1.Location = new System.Drawing.Point(508, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "If system up-time is high, then restart your computer from the start menu.";
            // 
            // tb_object
            // 
            this.tb_object.Location = new System.Drawing.Point(84, 248);
            this.tb_object.Name = "tb_object";
            this.tb_object.Size = new System.Drawing.Size(110, 20);
            this.tb_object.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(81, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Object";
            // 
            // tb_counter
            // 
            this.tb_counter.Location = new System.Drawing.Point(236, 248);
            this.tb_counter.Name = "tb_counter";
            this.tb_counter.Size = new System.Drawing.Size(150, 20);
            this.tb_counter.TabIndex = 11;
            // 
            // tb_instance
            // 
            this.tb_instance.Location = new System.Drawing.Point(422, 248);
            this.tb_instance.Name = "tb_instance";
            this.tb_instance.Size = new System.Drawing.Size(93, 20);
            this.tb_instance.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(233, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Counter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(419, 221);
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(634, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Please enter the following information exactly as it appears in Windows Perfmoran" +
    "ce Monitor: (case-sensitive)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Counter List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(345, 285);
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
            this.userinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userinput.ForeColor = System.Drawing.Color.Silver;
            this.userinput.Location = new System.Drawing.Point(103, 147);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(103, 22);
            this.userinput.TabIndex = 20;
            this.userinput.Text = "Your counter";
            // 
            // network_packetrecieved
            // 
            this.network_packetrecieved.AutoSize = true;
            this.network_packetrecieved.ForeColor = System.Drawing.Color.Silver;
            this.network_packetrecieved.Location = new System.Drawing.Point(373, 48);
            this.network_packetrecieved.Name = "network_packetrecieved";
            this.network_packetrecieved.Size = new System.Drawing.Size(117, 13);
            this.network_packetrecieved.TabIndex = 21;
            this.network_packetrecieved.Text = "Packets Recieved/sec";
            // 
            // network_packetsent
            // 
            this.network_packetsent.AutoSize = true;
            this.network_packetsent.ForeColor = System.Drawing.Color.Silver;
            this.network_packetsent.Location = new System.Drawing.Point(373, 35);
            this.network_packetsent.Name = "network_packetsent";
            this.network_packetsent.Size = new System.Drawing.Size(93, 13);
            this.network_packetsent.TabIndex = 22;
            this.network_packetsent.Text = "Packets Sent/sec";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(373, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Network:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(508, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "System:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "CPU:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(188, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Memory:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(53, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Your Counter:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 26);
            this.comboBox1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(556, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Datatype";
            // 
            // monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(699, 345);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.network_packetsent);
            this.Controls.Add(this.network_packetrecieved);
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
            this.Controls.Add(this.network_packet);
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
        private System.Windows.Forms.Label network_packet;
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
        private System.Windows.Forms.Label network_packetrecieved;
        private System.Windows.Forms.Label network_packetsent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}


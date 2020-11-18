using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiwiecDesktopMonitor
{
    public partial class CounterList : Form
    {
        public CounterList()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            object1.Text = "PhysicalDisk";
            object1.ReadOnly = true;
            object1.BorderStyle = 0;
            object1.BackColor = this.BackColor;
            object1.TabStop = false;
            object1.Multiline = true;

            object2.Text = "PhysicalDisk";
            object2.ReadOnly = true;
            object2.BorderStyle = 0;
            object2.BackColor = this.BackColor;
            object2.TabStop = false;
            object2.Multiline = true;


            object3.Text = "PhysicalDisk";
            object3.ReadOnly = true;
            object3.BorderStyle = 0;
            object3.BackColor = this.BackColor;
            object3.TabStop = false;
            object3.Multiline = true;

            counter1.Text = "PhysicalDisk";
            counter1.ReadOnly = true;
            counter1.BorderStyle = 0;
            counter1.BackColor = this.BackColor;
            counter1.TabStop = false;
            counter1.Multiline = true;

            counter2.Text = "PhysicalDisk";
            counter2.ReadOnly = true;
            counter2.BorderStyle = 0;
            counter2.BackColor = this.BackColor;
            counter2.TabStop = false;
            counter2.Multiline = true;

            counter3.Text = "PhysicalDisk";
            counter3.ReadOnly = true;
            counter3.BorderStyle = 0;
            counter3.BackColor = this.BackColor;
            counter3.TabStop = false;
            counter3.Multiline = true;

            instance1.Text = "PhysicalDisk";
            instance1.ReadOnly = true;
            instance1.BorderStyle = 0;
            instance1.BackColor = this.BackColor;
            instance1.TabStop = false;
            instance1.Multiline = true;

            instance2.Text = "PhysicalDisk";
            instance2.ReadOnly = true;
            instance2.BorderStyle = 0;
            instance2.BackColor = this.BackColor;
            instance2.TabStop = false;
            instance2.Multiline = true;

            instance3.Text = "PhysicalDisk";
            instance3.ReadOnly = true;
            instance3.BorderStyle = 0;
            instance3.BackColor = this.BackColor;
            instance3.TabStop = false;
            instance3.Multiline = true;

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SiwiecDesktopMonitor
{

    public partial class monitor : Form
    {


        PerformanceCounter cpuTimeCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

        PerformanceCounter cpuPerformanceCounter = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");

        PerformanceCounter cpuFrequencyCounter = new PerformanceCounter("Processor Information", "Processor Frequency", "_Total");

        PerformanceCounter cpuUtilityCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");

        PerformanceCounter cpuThreadCounter = new PerformanceCounter("Process", "Thread Count", "_Total");

        PerformanceCounter availableMemoryCounter = new PerformanceCounter("Memory", "Available MBytes");

        PerformanceCounter cacheMemoryCounter = new PerformanceCounter("Memory", "Cache Bytes");

        PerformanceCounter systemUpTimeCounter = new PerformanceCounter("System", "System Up Time");




        public monitor()
        {
            InitializeComponent();
        }

        private void btn_enter_Click_1(object sender, EventArgs e)
        {
            string Object = tb_object.Text;
            string Counter = tb_counter.Text;
            string Instance = tb_instance.Text;
    

            PerformanceCounter userInputCounter = new PerformanceCounter(Object, Counter, Instance);

            userinput.Text = "Your counter:" + " " + userInputCounter.NextValue() + "  ";
        }




        //Each time the timer ticks (in milliseconds) these counters refresh. This can be changed in timer properties.
        private void timer1_Tick(object sender, EventArgs e)
        {
            cpu_time.Text = "% Processor Time:" + "   " + (int)cpuTimeCounter.NextValue() + "  " + "%";

            cpu_performance.Text = "% Processor Performance:" + "   " + (int)cpuPerformanceCounter.NextValue() + "  " + "%";

            cpu_freq.Text = "Processor Frequency:" + "   " + cpuFrequencyCounter.NextValue() + "  ";

            cpu_utility.Text = "Processor Utility:" + "   " + (int)cpuUtilityCounter.NextValue() + "  " + "%";

            cpu_thread.Text = "Thread Count:" + "   " + (int)cpuThreadCounter.NextValue() + "  " + "%";

            memory_available.Text = "Available Memory (mb):" + "   " + (int)availableMemoryCounter.NextValue() + "  " + "mb";

            memory_cached.Text = "Cached Memory (mb):" + "   " + (int)cacheMemoryCounter.NextValue() + "  " + "mb";

            system_uptime.Text = "System Up-time" + "   " + ((int)systemUpTimeCounter.NextValue() / 60) / 60 + "  " + "hrs.";

        }
    }
}

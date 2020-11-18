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
using SiwiecDesktopMonitor.Properties;
using System.Timers;

namespace SiwiecDesktopMonitor
{

    public partial class monitor : Form
    {


        PerformanceCounter cpuTimeCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

        PerformanceCounter cpuPerformanceCounter = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");

        PerformanceCounter cpuFrequencyCounter = new PerformanceCounter("Processor Information", "Processor Frequency", "_Total");

        PerformanceCounter cpuUtilityCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");

        PerformanceCounter networkPacketCounter = new PerformanceCounter("Network interface","Packets/sec","Intel[R] Wireless-AC 9260 160MHz");

        PerformanceCounter networkPacketSentCounter = new PerformanceCounter("Network interface", "Packets Sent/sec", "Intel[R] Wireless-AC 9260 160MHz");

        PerformanceCounter networkPacketRecievedCounter = new PerformanceCounter("Network interface", "Packets Received/sec", "Intel[R] Wireless-AC 9260 160MHz");

        PerformanceCounter availableMemoryCounter = new PerformanceCounter("Memory", "Available MBytes");

        PerformanceCounter cacheMemoryCounter = new PerformanceCounter("Memory", "Cache Bytes");

        PerformanceCounter systemUpTimeCounter = new PerformanceCounter("System", "System Up Time");



        public monitor()
        {
            InitializeComponent();
        }


        //private void btn_enter_Click_1(object sender, EventArgs e)
        //{
        //    string Object = tb_object.Text.ToString();
        //    string Counter = tb_counter.Text.ToString();
        //    string Instance = tb_instance.Text.ToString();


        //    PerformanceCounter userInputCounter = new PerformanceCounter(Object, Counter, Instance);


        //    userinput.Text = "Your counter:" + " " + userInputCounter.NextValue() + "  ";
        //}

        //Each time the timer ticks (in milliseconds) these counters refresh. This can be changed in timer properties.
        private void timer1_Tick(object sender, EventArgs e)
        {

            cpu_time.Text = "% Processor Time:" + "   " + (int)cpuTimeCounter.NextValue() + "  " + "%";

            cpu_performance.Text = "% Processor Performance:" + "   " + (int)cpuPerformanceCounter.NextValue() + "  " + "%";

            cpu_freq.Text = "Processor Frequency:" + "   " + cpuFrequencyCounter.NextValue() + "  ";

            cpu_utility.Text = "Processor Utility:" + "   " + (int)cpuUtilityCounter.NextValue() + "  " + "%";

            network_packet.Text =  (int)networkPacketCounter.NextValue() + "  " + "Packets/sec";

            network_packetsent.Text = (int)networkPacketRecievedCounter.NextValue() + "  " + "Packets Sent/sec";

            network_packetrecieved.Text = (int)networkPacketSentCounter.NextValue() + "  " + "Packets Recieved/sec";

            memory_available.Text = "Available Memory:" + "   " + (int)availableMemoryCounter.NextValue() + "  " + "mb";

            memory_cached.Text = "Cached Memory:" + "   " + (int)cacheMemoryCounter.NextValue()/1000000+ "  " + "mb";

            system_uptime.Text = "System Up-time" + "   " + ((int)systemUpTimeCounter.NextValue() / 60) / 60 + "  " + "hrs.";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CounterList counterList = new CounterList();

            counterList.Show();



        }
    }
}

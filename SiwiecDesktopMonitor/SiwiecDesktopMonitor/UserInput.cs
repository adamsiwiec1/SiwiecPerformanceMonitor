using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiwiecDesktopMonitor
{
    class UserInput
    {
        public string ObjectName { get; set; }

        public string Counter { get; set; }

        public string Instance { get; set; }

        public UserInput(string objectName, string counter, string instance)
        {
            ObjectName = objectName;
            Counter = counter;
            Instance = instance;
        }

        public UserInput(){ }
    }
}

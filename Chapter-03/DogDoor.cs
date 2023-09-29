using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace HFOO_03
{
    class DogDoor
    {
        private bool open;
        private Timer newTimer;

        public DogDoor()
        {
            this.open = false;
            newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = 4000;
        }

        private void DisplayTimeEvent(object sender, ElapsedEventArgs e)
        {
            Close();
            open = false;
            newTimer.Stop();
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens."); 
            open = true;
            newTimer.Start();
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}

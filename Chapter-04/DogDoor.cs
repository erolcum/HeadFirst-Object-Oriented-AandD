using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace HFOO_04
{
    class DogDoor
    {
        private bool open;
        private Timer newTimer;
        private List<Bark> allowedBarks;

        public DogDoor()
        {
            this.open = false;
            allowedBarks = new List<Bark>();
            newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = 5000;
        }

        public void addAllowedBark(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> getAllowedBarks()
        {
            return allowedBarks;
        }

        private void DisplayTimeEvent(object sender, ElapsedEventArgs e)
        {
            Close();
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace HFOO_02
{
    class Remote
    {
        private DogDoor door;
        private Timer newTimer;
        public Remote(DogDoor door)
        {
            this.door = door;
            newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = 4000;
        }

        public void pressButton()
        {
            Console.WriteLine("Pressing the remote control button...\n");
            if (door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
                
                newTimer.Start();
                
            }
        }

        private void DisplayTimeEvent(object sender, ElapsedEventArgs e)
        {
            door.Close();
            newTimer.Stop();
        }
    }
}

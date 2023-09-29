using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace HFOO_04
{
    class Remote
    {
        private DogDoor door;  
        public Remote(DogDoor door)
        {
            this.door = door;        
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
            }
        }
    }
}

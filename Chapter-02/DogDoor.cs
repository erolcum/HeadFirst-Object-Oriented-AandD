using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_02
{
    class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens."); 
            open = true;
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

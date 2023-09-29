using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_03
{
    class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void recognize(string bark)
        {
            Console.WriteLine($"   BarkRecognizer: Heard a '{bark}'");
            door.Open();
        }
    }
}

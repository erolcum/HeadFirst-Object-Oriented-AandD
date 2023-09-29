using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_04
{
    class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void recognize(Bark bark)
        {
            Console.WriteLine($"   BarkRecognizer: Heard a '{bark.getSound()}'");
            List<Bark> allowedBark = door.getAllowedBarks();
            foreach (Bark b in allowedBark)
            {
                if (b.equals(bark)) { door.Open(); return; }
            }

            Console.WriteLine("This dog is not allowed.");
        }
    }
}

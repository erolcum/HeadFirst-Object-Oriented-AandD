using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_02
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...\n"); 

            remote.pressButton();

            Console.WriteLine("\nFido has gone outside...");           
            Console.WriteLine("\nFido's all done...");        
            Console.WriteLine("\nFido's back inside...\n");            
            Console.ReadLine();
        }
    }
}

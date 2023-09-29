using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HFOO_03
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Fido starts barking.");
            recognizer.recognize("Woof");

            Console.WriteLine("\nFido has gone outside...");

            Console.WriteLine("\nFido's all done...");

            Thread.Sleep(10000);

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("\nFido starts barking.");
            recognizer.recognize("Woof");

            Console.WriteLine("\nFido's back inside...");

            Console.ReadLine();
        }
    }
}

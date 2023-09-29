using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HFOO_04
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            door.addAllowedBark(new Bark("rowlf"));
            door.addAllowedBark(new Bark("rooowlf"));
            door.addAllowedBark(new Bark("rawlf"));
            door.addAllowedBark(new Bark("woof"));
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            // Simulate the hardware hearing a bark
            Console.WriteLine("Bruce starts barking.");
            recognizer.recognize(new Bark("rowlf"));

            Console.WriteLine("\nBruce has gone outside...");

            Thread.Sleep(10000);

            Console.WriteLine("\nBruce all done...");
            Console.WriteLine("...but he's stuck outside!");

            // Simulate the hardware hearing a bark (not Bruce!)
            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking.");
            recognizer.recognize(smallDogBark);

            Thread.Sleep(5000);

            // Simulate the hardware hearing a bark again
            Console.WriteLine("\nBruce starts barking.");
            recognizer.recognize(new Bark("woof"));

            Console.WriteLine("\nBruce's back inside...");

            Console.ReadLine();
        }
    }
}

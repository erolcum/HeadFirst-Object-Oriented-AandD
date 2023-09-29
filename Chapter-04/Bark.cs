using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_04
{
    class Bark
    {
        private String sound;

        public Bark(string sound)
        {
            this.sound = sound;
        }

        public string getSound()
        {
            return sound;
        }

        public bool equals(object bark)
        {
            if (bark is Bark) {
                Bark otherBark = (Bark)bark;
                if (this.sound.Equals(otherBark.sound))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

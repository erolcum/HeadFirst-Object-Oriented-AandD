using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFOO_01
{
    class Guitar
    {
        private String serialNumber;
        private double price;
        GuitarSpec spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public GuitarSpec getSpec()
        {
            return spec;
        }


    }
}

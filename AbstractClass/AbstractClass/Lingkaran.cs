using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class lingkaran : Bentuk
    {
        public double Radius { get; set; }

        public lingkaran(double r)
        {
            Nama = "Lingkaran";
            Radius = r;

        }

        public override double Luas()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Mempunyai radius ={Radius}");
        }

    }
}

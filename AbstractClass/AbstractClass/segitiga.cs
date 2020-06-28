using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class segitiga : Bentuk
    {
        public double a { get; set; }
        public double t { get; set; }

        public segitiga(double alas,
            double tinggi)
        {
            Nama = "Segitiga";
            a = alas;
            t = tinggi;
        }

        public override double Luas()
        {
            return (a * t)/2;
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"Mempunyai alas = {a} dan tinggi = {t}");
        }
    }
}

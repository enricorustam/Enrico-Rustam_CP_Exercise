using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Bentuk
    {
        public string Nama { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Ini adalah {Nama}");
        }

        public abstract double Luas();
    }
}

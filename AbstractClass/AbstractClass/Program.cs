using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bentuk[] bentuk = { new lingkaran(7), new persegiPanjang(4, 5), new segitiga(4,6), new persegi(3), new belahKetupat(4,6) };

                foreach (Bentuk b in bentuk)
                {
                    b.GetInfo();

                    Console.WriteLine("Luas {0} : {1:f2}",
                    b.Nama, b.Luas());

                    //Lingkaran testlingkaran = b as Lingkaran;
                    //if (testlingkaran == null)
                    //{
                    //    Console.WriteLine("Ini bukan lingkaran");
                    //}
                    //if (b is Lingkaran)
                    //{
                    //    Console.WriteLine("ini bukan persegi panjang");
                    //}

                    Console.WriteLine();
                }
                //object ling1 = new Lingkaran(4);

                //Lingkaran ling2 = (Lingkaran)ling1;
                //Console.WriteLine("Luas {0} adalah {1:f2}",
                //    ling2.Nama, ling2.Luas());


                //Console.ReadLine();

            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}

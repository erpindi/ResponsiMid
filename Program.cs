using System;

namespace pindi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : Yakobus Erpindi Purwanto");
            Console.WriteLine("NIM  : 19.11.2835");
            Console.WriteLine("");

            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();
            
            karyawan1.No = 1;
            karyawan1.Nik = 190302123;
            karyawan1.Nama = "Paijo";
            karyawan1.Gaji = 3000000;

            karyawan2.No = 2;
            karyawan2.Nik = 190302124;
            karyawan2.Nama = "Jono";
            karyawan2.Gaji = 2000000;

           

            Console.WriteLine("No    NIK/Nama \t\tGaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.InfoKaryawan();
            karyawan2.InfoKaryawan();
           
            Console.WriteLine("");
            Console.WriteLine("Asyikk dapat kenaikan gaji 10%");
            Console.WriteLine("");
            Console.WriteLine("No    NIK/Nama \t\tGaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.BonusGaji();
            karyawan2.BonusGaji();
            

            Console.ReadKey();
        }
    }
    
}

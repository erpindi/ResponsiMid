using System;
using System.Collections.Generic;
using System.Text;

namespace pindi
{
    class Karyawan
    {
       
        
            public int No { get; set; }
            public int Nik { get; set; }
            public string Nama { get; set; }
            public int Gaji { get; set; }



            public void InfoKaryawan()
            {
                if (Gaji < 0)
                {
                    Gaji = 0;
                }else
            {
                Gaji = Gaji;
            }

                Console.WriteLine("{0}   {1}\t{2}\t{3}        ", No, Nik, Nama, Gaji);

            }

            public void BonusGaji()
            {
               
            double tmp = 0;
            tmp = 0.1 * Gaji;
            Gaji += Convert.ToInt32(tmp);
            Console.WriteLine("{0}  {1}\t{2}\t{3}        ", No, Nik, Nama, Gaji * 0.1 + Gaji);

            }


        
    }
}

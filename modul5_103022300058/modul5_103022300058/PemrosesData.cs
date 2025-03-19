using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300058
{
    class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic temp1 = a;
            dynamic temp2 = b;
            dynamic temp3 = c;

            dynamic terbesar = temp1;

            if (temp2 >= terbesar)
            {
                terbesar = temp2;
            }

            if (temp3 >= terbesar)
            {
                terbesar = temp3;
            }

            Console.WriteLine("Angka Terbesar: "+ terbesar);
        }
    }
}

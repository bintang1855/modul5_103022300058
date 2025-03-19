
﻿using System.ComponentModel;
using modul5_103022300058;

namespace modul5_103022300058
{
    class Program
    {
        static void Main(String[] args)
        {
            PemrosesData pd = new PemrosesData();

            pd.DapatkanNilaiTerbesar(30, 00, 58);
            SimpleDataBase<int> SimpleDB = new SimpleDataBase<int>();
            SimpleDB.AddNewData(30);
            SimpleDB.AddNewData(00);
            SimpleDB.AddNewData(58);
            SimpleDB.PrintAllData();


        }

    }
    
}


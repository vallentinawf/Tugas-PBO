﻿using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Kopilih
{
    class Program
    {

        static void Main(string[] args)
        {
            MainMenu kopi = new MainMenu();
            kopi.Greet();
            kopi.MainOrdering();
            kopi.InputData();
            kopi.Conlusing();
        }  
       
    }
}

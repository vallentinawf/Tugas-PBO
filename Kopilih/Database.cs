﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Kopilih
{
    class Database
    {
        public SQLiteConnection myConnection;

        public string name { get; internal set; }
        public string address { get; internal set; }
        public short phonenumber { get; internal set; }

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source = database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                
                SQLiteConnection.CreateFile("database.sqlite3");
                System.Console.WriteLine("Database file created");
            }
            
        }

        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Kopilih
{
    public class Data
    {
        protected string name;
        protected string address;
        protected int phonenumber;

        public virtual void InputData()
        { 
            Database databaseObject = new Database();

            Console.WriteLine("What is Your Name?  ");
            databaseObject.name = Console.ReadLine();
            
            Console.WriteLine("And Your Address? ");
            databaseObject.address = Console.ReadLine();

            Console.WriteLine("What is Your Phone Number? ");
            databaseObject.phonenumber = Convert.ToInt16(Console.ReadLine());


            /**
             * INSERT INTO DATABASE
             * *
             */ 
             databaseObject.OpenConnection();
             string query = "INSERT INTO Customer ('Name','Address','PhoneNumber') VALUES ('"+ databaseObject.name +"', '"+ databaseObject.address +"', '"+ databaseObject.phonenumber +"')";
             SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
             
             myCommand.ExecuteNonQuery();
             databaseObject.CloseConnection();

             Console.ReadKey();
             
           
        }


    }
}

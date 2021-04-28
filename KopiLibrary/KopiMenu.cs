using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopiLibrary
{
    public class KopiMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Kopilih`s Menu : ");
            Console.WriteLine($"1. {NamaKopi.Espresso}         RP.{HargaKopi.Espresso}");
            Console.WriteLine($"2. {NamaKopi.Cappuccino}       RP.{HargaKopi.Cappuccino}");
            Console.WriteLine($"3. {NamaKopi.CaffeLatte}       RP.{HargaKopi.CaffeLatte}");
            Console.WriteLine($"4. {NamaKopi.VietnamDrip}      RP.{HargaKopi.VietnamDrip}");
            Console.WriteLine($"5. {NamaKopi.V60}              RP.{HargaKopi.V60}");
            Console.WriteLine($"6. {NamaKopi.AeroPress}        Rp.{HargaKopi.AeroPress}");
            Console.WriteLine();
        }


        public double total;
        public double price;
        public double CalculateOrder()
        {
            Console.WriteLine("How Many Coffee Do You Want To Order?");
            int quantity = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Which coffee do you want?");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        price = 18000;
                        break;
                    case "2":
                        price = 28000;
                        break;
                    case "3":
                        price = 23000;
                        break;
                    case "4":
                        price = 30000;
                        break;
                    case "5":
                        price = 25000;
                        break;
                    case "6":
                        price = 29000;
                        break;
                }
                total = total += price;
            }
            return total;
        }
    }
            
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KopiLibrary;

namespace Kopilih
{
    
    public class MainMenu : Data
    {
        public double total;


        public void Greet()
        {
            Console.WriteLine("Welcome to Kopilih!");
            Console.WriteLine("You can order your favorite coffee, and we will deliver it for you!");
            Console.WriteLine();

        }

        public void MainOrdering()
        {
            KopiLibrary.KopiMenu orderan = new KopiLibrary.KopiMenu();
            orderan.ShowMenu(); //Memanggil method dari KopiLibrary untuk menampilkan menu kopi
            total =  orderan.CalculateOrder();  //Menggunakan method calculate dari KopiLibrary untuk menghitung total pembayaran
        }

        public override void InputData()
        {
            Console.WriteLine("====Please Fill Out This Form====");
            base.InputData();

        }
        public void Conlusing()
        {
            Console.WriteLine();
            Console.WriteLine("Your Total Bill Is : Rp.{0}", total);
            Console.WriteLine("Your Order Is Being Processed.");
            Console.WriteLine("Our Courier Will Deliver Your Order.");
            Console.WriteLine("Thank You");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxiapps
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class Taxi
            Taxi driver = new Taxi();
            Taxi penumpang = new Taxi();

            //mengeset nilai properties objek driver dan penumpang
            driver.Driver_Name = "Agus";
            driver.jumlah = "3";
            driver.On_Duty = "sedang bertugas";

            penumpang.Driver_Name = "Ari";
            penumpang.jumlah = "2";
            penumpang.On_Duty = "sedang dalam perjalanan";

            //memanggil method Taxiinfo, Jemput Penumpang, dan penurunan penumpang
            driver.Taxi_info();
            driver.Pick_Up_Passenger();
            driver.Drop_Of_Passenger();

            penumpang.Taxi_info();
            penumpang.Pick_Up_Passenger();
            penumpang.Drop_Of_Passenger(); 

            Console.ReadKey();

    

        }
    }
}

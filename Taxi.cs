using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxiapps
{
   public class Taxi
    {
        //properties 
        public string Driver_Name { get; set; }
        public string On_Duty { get; set; }
        public string Num_Passenger { get; set; }
        public string jumlah { get; set; }

        //Method
        public void Taxi_info()
        {
            Console.WriteLine("Nama Driver: {0}", Driver_Name);
            Console.WriteLine("sedang bertugas: {0}", On_Duty);
            Console.WriteLine("Jumlah Penumpang: {0}", jumlah );
            Console.WriteLine("Num_Passenger: {0}", Num_Passenger);
            Console.WriteLine("Anda Telah Melakukan Pemesanan Taxi");
        }

        public void Pick_Up_Passenger()
        {
            Console.WriteLine("{0} Driver sedang menuju ke lokasi anda, silahkan menunggu\n", Driver_Name);
        }

        public void Drop_Of_Passenger()
        {
            Console.WriteLine("{0} Lokasi tujuan anda sudah dekat ", Num_Passenger);
        }
    }
}

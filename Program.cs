using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat Objek dari Class Taxi
            TAXI A = new TAXI();
            TAXI B = new TAXI();
            TAXI C = new TAXI();

            //Mengatur Data Objek A, B, dan C
            A.Name = "Johny";
            A.Duty = "OFF";
            A.Sum = 0;

            B.Name = "Lin Tan Huang";
            B.Duty = "ON";
            B.Sum = 4;

            C.Name = "Kyujin Lee";
            C.Duty = "ON";
            C.Sum = 2;

            //Memanggil method
            Console.WriteLine("\n");
            A.Info();
            A.Drop();
            Console.WriteLine("\n");
            B.Info();
            B.PickUp();
            Console.WriteLine("\n");
            C.Info();
            C.PickUp();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}

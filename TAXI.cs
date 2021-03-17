using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan_3
{
    public class TAXI
    {
        //Properties
        public string Name { get; set; }
        public string Duty { get; set; }
        public int Sum { get; set; }

        //Method
        public void Info()
        {
            Console.WriteLine("Driver = {0}", Name);
            Console.WriteLine("Duty = {0}", Duty);
            Console.WriteLine("Passanger = {0}", Sum);
        }

        public void PickUp() 
        {
            Console.WriteLine("He is still picking up Passangers");
        }

        public void Drop()
        {
            Console.WriteLine("He has droped off the passangers");
        }
    }
}

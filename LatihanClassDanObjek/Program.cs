using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObjek
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Taxi
            Taxi taxi = new Taxi();
            Taxi taksi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Haidar";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taksi.DriverName = "Yoga";
            taksi.OnDuty = false;
            taksi.NumPassenger = 0;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            taksi.TaxiInfo();
            taksi.PickUpPassenger();
            taksi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}

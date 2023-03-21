using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObjek
{
    public class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        public string Status { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("\nNama driver: {0}", DriverName);
            
            if (OnDuty == true)
            {
                Console.WriteLine("Sedang bertugas: Iya", OnDuty);
            } else if (OnDuty == false)
            {
                Console.WriteLine("Sedang bertugas: Tidak", OnDuty);
            }

            Console.WriteLine("Jumlah penumpang: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {

            if (OnDuty == true)
            {
                Console.WriteLine("\n{0} Sedang menjemput penumpang", DriverName);
            } else if (OnDuty == false)
            {
                Console.WriteLine("\n{0} Sedang tidak menjemput penumpang", DriverName);
            }
        }

        public void DropOffPassenger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("{0} belum selesai mengantar penumpang", DriverName);
            }
            else if (OnDuty == false)
            {
                Console.WriteLine("{0} Selesai mengantar penumpang", DriverName);
            }
        }

    }
}

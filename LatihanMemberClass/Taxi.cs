using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        //Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if(OnDuty==true) 
                {
                
                    Console.WriteLine("On Duty : Yes");
                }
            else if(OnDuty==false) 
                {
                    Console.WriteLine("On Duty : No");
                }
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }
    }
}

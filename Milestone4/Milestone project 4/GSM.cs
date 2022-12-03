using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_project_4
{
    internal class GSM :MobilePhone
    {
        public static MobilePhone Iphone13 = new MobilePhone("iPhone13", "apple",
            "apple", 900, 450, 4, 2, "8inches", "black" );


        //Method to display all GSM information
        public void DisplayGSMInfo()
        {
            Console.WriteLine("Your GSM informattion is " + model + manufacturer + owner + size + color + size + color + price
                + batteryModel + batteryHoursIdle + batteryHoursTalk);
        }

        public class GSMTestFuctionality 
        {
             
        }

        private string callHistory;
        public string CallHistory
        {
            get
            {
                return callHistory;
            }
        }

        
    }
}

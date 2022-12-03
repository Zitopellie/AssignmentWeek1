using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_project_4
{
    public class MobilePhone
    {

        public string model, manufacturer, owner, size, color;

        public int price, batteryModel, batteryHoursIdle, batteryHoursTalk;



        //constructors with no parameters passed
         public MobilePhone()
        {
            model = "No Model specified";
            manufacturer = "No Manufacturer specified";
            owner = "No owner specified";
            size = "No specified size";
            color = "Default color Yellow";
            price = 0;
            batteryModel = 0;
            batteryHoursIdle = 0;
            batteryHoursTalk = 0;

        }


        //constructor with all the parameters passed
        public MobilePhone(string Model,string Manufacturer, string Owner, int Price,
            int BatteryModel, int BatteryHoursIdle,
            int BatteryHoursTalk, string Size, string Color)
        {
            model = Model;
            manufacturer = Manufacturer;
            owner = Owner;
            price = Price;
            batteryModel = BatteryModel;
            batteryHoursIdle = BatteryHoursIdle;
            batteryHoursTalk = BatteryHoursTalk;
            size = Size;
            color = Color;  

        }

        //Constructor with no specified size and color
        public MobilePhone(string Model, string Manufacturer, string Owner, int Price,
            int BatteryModel, int BatteryHoursIdle,
            int BatteryHoursTalk)
        {
            model = Model;
            manufacturer = Manufacturer;
            owner = Owner;
            price = Price;
            batteryModel = BatteryModel;
            batteryHoursIdle = BatteryHoursIdle;
            batteryHoursTalk = BatteryHoursTalk;
            size = "No specified size";
            color = "Yellow";

        }


        //constructor with no battery information
        public MobilePhone(string Model, string Manufacturer, string Owner, int Price, string Size, string Color)
        {
            model = Model;
            manufacturer = Manufacturer;
            owner = Owner;
            price = Price;
            batteryModel = 0;
            batteryHoursIdle = 0;
            batteryHoursTalk = 0;
            size = Size;
            color = Color;

        }



        // constructor with no manufacturer, battery information, owner, and  price information
        public MobilePhone(string Model, string Size, string Color)
        {
            model = Model;
            manufacturer = "No Manufacturer specified";
            owner = "No owner specified";
            price = 0;
            batteryModel = 0;
            batteryHoursIdle = 0;
            batteryHoursTalk = 0;
            size = Size;
            color = Color;

        }
    }
}

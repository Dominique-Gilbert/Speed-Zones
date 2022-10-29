using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Question_1_Speed_Zones
{
    internal class Program
    {
        enum ZoneName {School, City, Highway}
        enum SpeedLimit {SCHOOL_ZONE_SPEED = 20, CITY_STREET_SPEED = 30, HIGHWAY_SPEED = 55 }
        static void Main(string[] args)
        {
            int num = 0;
            while (num != 1 || num != 2 || num != 3)
            {
                WriteLine("********************************************************");
                WriteLine("Please enter a zone Number");
                WriteLine("1." + ZoneName.School);
                WriteLine("2." + ZoneName.City);
                WriteLine("3." + ZoneName.Highway);
                WriteLine(" ");
                WriteLine("********************************************************");
                try
                {
                    num = int.Parse(ReadLine());
                }
                catch (Exception ex) {
                    // just used to stop string exceptions or errors
                }

                Clear();
                WriteLine("Please Enter the correct number ");
            }

            WriteLine(" ");
            WriteLine("Please enter your current speed");
            int num1 = int.Parse(ReadLine());
            if (num == 1) {
                if (num1 <= int.Parse(SpeedLimit.SCHOOL_ZONE_SPEED.ToString()))
                {
                    WriteLine("Thank you for maintaining the speed limit in your CITY zone");
                }
                else if (num1 > int.Parse(SpeedLimit.SCHOOL_ZONE_SPEED.ToString()))
                {
                    WriteLine("Please slow down and maintain the speed limit of 20 in the School Zone");
                }
                

            }
            if (num == 2)
            {
                if (num1 <= int.Parse(SpeedLimit.CITY_STREET_SPEED.ToString()))
                {
                    WriteLine("Thank you for maintaining the speed limit in your CITY zone");
                }
                else if (num1 > int.Parse(SpeedLimit.CITY_STREET_SPEED.ToString()))
                {
                    WriteLine("Please slow down and maintain the speed limit of 30 in the City Zone");
                }
            }
            if (num == 3)
            {
                if (num1 <= int.Parse(SpeedLimit.HIGHWAY_SPEED.ToString()))
                {
                    WriteLine("Thank you for maintaining the speed limit in your CITY zone");
                }
                else if (num1 > int.Parse(SpeedLimit.HIGHWAY_SPEED.ToString()))
                {
                    WriteLine("Please slow down and maintain the speed limit of 55 in the Highway Zone");
                }
            }
            Read();
        }
        
    }
}

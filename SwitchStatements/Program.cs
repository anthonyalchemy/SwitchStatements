using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetDay(80));

            Console.ReadLine();

        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)//figure out the dayNum then do something
            {
                case 0:
                    dayName = "Sunday"; // if dayNum is 0 = sunday 
                    break; // break out of structure we are in 
                case 1:
                    dayName = "Monday";  
                    break;
                case 2:
                    dayName = "Tuesday"; 
                    break;
                case 3:
                    dayName = "Wednesday";  
                    break;
                case 4:
                    dayName = "Thursday"; 
                    break;
                case 5:
                    dayName = "Friday"; 
                    break;
                case 6:
                    dayName = "Saturday"; 
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }




            return dayName;

        }
    }
}

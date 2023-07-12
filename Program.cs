using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String to Integer using TryParse
            string strNumber = "15";
            int number = 5;

            try
            {

                Int32.TryParse(strNumber, out number);
                Console.WriteLine("Added the string and the Integer" + (number+strNumber));
               
            }
            catch (Exception e)
            {

                Console.WriteLine("The string '" + strNumber + "' cannot be converted to an integer");

            }

            /*

            //String to DateTime Object
            string strDateTime = "2023-07-12T12:34:56";
            DateTime dateTime;

            try
            {
                
                dateTime = Convert.ToDateTime(strDateTime);
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The string '" + strDateTime + "' cannot be converted to a DateTime");
            }

            //String to Time Span Using Parse

            string strTimeSpan = "01:02:03";
            TimeSpan timeSpan;

            try
            {
                
                timeSpan = TimeSpan.Parse(strTimeSpan);
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The string '" + strTimeSpan + "' cannot be converted to a TimeSpan");
            }
            */


        }
    }
}


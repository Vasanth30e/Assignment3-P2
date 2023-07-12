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
            /*
            //String to Integer using TryParse
            string strNumber = "15";
            int number;

            try
            {

                Int32.TryParse(strNumber, out number);
                Console.WriteLine("Added the string and the Integer" + (number+strNumber));
               
            }
            catch (Exception e)
            {

                Console.WriteLine("The string '" + strNumber + "' cannot be converted to an integer");

            }
            finally 
            { 
                Console.ReadKey(); 
            }

            
            
            //String to DateTime Object
            string strDateTime = "2023-07-12T12:34:56";
            DateTime dateTime;

            try
            {
                
                dateTime = Convert.ToDateTime(strDateTime);
                dateTime = dateTime.AddMonths(-1);
                Console.WriteLine("After reduced One Month " + dateTime);

            }
            catch (Exception e)
            {
                
                Console.WriteLine("The string '" + strDateTime + "' cannot be converted to a DateTime");
            }

            finally 
            { 
                Console.ReadKey(); 
            }
            */

            //String to Time Span Using Parse

            string strTimeSpan = "01:02:03";
            TimeSpan timeSpan;

            try
            {
                
                timeSpan = TimeSpan.Parse(strTimeSpan);
                timeSpan = timeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("Added 2 hours " +  timeSpan);
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The string '" + strTimeSpan + "' cannot be converted to a TimeSpan");
            }
            finally 
            { 
                Console.ReadKey(); 
            }
            
            


        }
    }
}


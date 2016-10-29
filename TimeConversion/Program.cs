using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            var array = time.Split(':');

            int hours = Convert.ToInt32(array[0]);
            string h = hours.ToString();


            if (time.ToUpper().Contains("PM") && hours != 12 && hours != 0)
            {
                h = (hours + 12).ToString();
            }

            if (time.ToUpper().Contains("AM") && hours == 12)
            {
                h = "00";
            }


            if (hours < 10 && h.Length == 1)
            {
                h = "0" + hours;
            }



            Console.WriteLine("{0}:{1}:{2}", h, array[1], array[2].Substring(0, 2));
            Console.ReadKey();
        }
    }
}

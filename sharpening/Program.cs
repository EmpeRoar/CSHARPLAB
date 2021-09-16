using System;

namespace sharpening
{

    class DateHelper {
        public static DateTime DateHelp(string dateStr) {
            var dateArray = dateStr.Split("-");
            return new DateTime(Int32.Parse(dateArray[0]), Int32.Parse(dateArray[1]), Int32.Parse(dateArray[2]));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var date = DateTime.Now;

            var date = new DateTime(2021,10,29);
            
            var datax = DateHelper.DateHelp("2021-10-29");

            Console.WriteLine($"{date.ToString("yyyy-MMMM-dd")}");
            Console.WriteLine($"{date.ToString("dddd")}");

            Console.WriteLine($"{datax.ToString("dddd")}");
        }
    }
}

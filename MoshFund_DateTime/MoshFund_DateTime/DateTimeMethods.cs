using System;

namespace MoshFund_DateTime
{
    public class DateTimeMethods
    {
        public DateTime dateTime;
        public void InitializeDateTime()
        {
            dateTime = new DateTime(2022, 4, 17);
        }
        public void CurrentDateTime()
        {
            var now = DateTime.Now;
            var currentHour = now.Hour;
            var currentMinute = now.Minute;
        }
        public void TodaysDate()
        {
            var today = DateTime.Today;
        }
        public void ModifyDateTime()
        {
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
        }
        public void DateTimeToString()
        {
            Console.WriteLine("Long Date: " + DateTime.Now.ToLongDateString());
            Console.WriteLine("Short Date: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Long Time: " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("Long Time: " + DateTime.Now.ToShortTimeString());
            Console.WriteLine("DateTime: " + DateTime.Now.ToString());
            Console.WriteLine("DateTime Format Specifier: " + DateTime.Now.ToString("F"));
            Console.WriteLine("DateTime Format Specifier: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
        }

    }
}

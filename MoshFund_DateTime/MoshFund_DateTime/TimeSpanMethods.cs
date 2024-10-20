using System;

namespace MoshFund_DateTime
{
    public class TimeSpanMethods
    {
        public void TimeSpanInitialization()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Hour, Mins, Seconds: " + timeSpan);

            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
        }

        public void TimeSpanProperties()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);
        }
        public void TimeSpanAddMethod()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Add Minutes: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Minutes: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));
        }
        public void TimeSpanToString()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var stringTimeSpan = timeSpan.ToString();
            Console.WriteLine(stringTimeSpan);

            var stringTime = "01:15:35";
            Console.WriteLine("Parse: " + TimeSpan.Parse(stringTime));

        }

    }
}

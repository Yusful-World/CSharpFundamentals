using System;

namespace MoshInt_InterfacePolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS... ");
        }
    }
}

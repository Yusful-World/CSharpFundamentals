using System;

namespace MoshAdvance_EventsDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending mail...." + e.Video.Title);
        }
    }
}

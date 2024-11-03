using System;

namespace MoshAdvance_EventsDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending text message..." + args.Video.Title);
        }
    }
}

using System;
using System.Threading;

namespace MoshAdvance_EventsDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //declare a delegate
        //declare an event
        //raise/publish the event
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        //EventHandler can be used instead of creating custom delegate
        //EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encoded(Video video)
        {
            Console.WriteLine("encoding video...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video } );

            //if (VideoEncoded != null)
                //VideoEncoded(this, EventArgs.Empty);
        }
    }
}

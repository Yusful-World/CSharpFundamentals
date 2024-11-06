using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
    }

    public class YouTubeApi
    {
        public List<Videos> GetVideos(string user)
        {
            try
            {
                throw new Exception("Some low level error occured");
            }
            catch (Exception e)
            {
                throw new YouTubeException("Could not fetch the video", e);
            }
            return new List<Videos>();
        }
    }
}

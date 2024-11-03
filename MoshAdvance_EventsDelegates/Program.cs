using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshAdvance_EventsDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" }; 
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService();    //subscriber 
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;    //subscription: should be called before the encoded method
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encoded(video);
        }
    }
}

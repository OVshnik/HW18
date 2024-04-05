using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace HW18
{
    public class GetVideoInfo: Command
    {
        Receiver receiver;
        public GetVideoInfo(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public override async Task Execute()
        {
            YoutubeClient client = new();
            var desc = await client.Videos.GetAsync(receiver.link);
            Console.WriteLine($"Video title: {desc.Title}+ Video description:{desc.Description}");
        }
    }
}

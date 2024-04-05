using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace HW18
{
    public class DownloadVideo:Command
    {
        Receiver receiver;
        public DownloadVideo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override async Task  Execute()
        {
            YoutubeClient client = new();

            var streamManifest = await client.Videos.Streams.GetManifestAsync(receiver.link);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            Console.WriteLine("Download complited");
        }

    }
}

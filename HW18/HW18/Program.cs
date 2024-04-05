using System;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace HW18;
internal class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Please provide link to the youtube video");
        var link = Console.ReadLine();

        Receiver receiver = new (link);

        Command command1 = new GetVideoInfo(receiver);

        Command command2 = new DownloadVideo(receiver);

        Sender sender = new();

        sender.SetCommand(command1);
        await sender.Execute();

        sender.SetCommand(command2);
        await sender.Execute();
    }
}
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using static System.Net.WebRequestMethods;
namespace YouTubeDowload
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Введите Ссылку на видео");
            var youTube = new YoutubeClient();
            var url = Console.ReadLine();
            var client = new Client();
            var getInfo = new ReceiverGetInfo();
            var dowload = new ReceiverDowload();
            client.SetCommand(new GetInfoCommand(getInfo));
            client.Execute(youTube,url);
            client.SetCommand(new DowloadVideoCommand(dowload));
            client.Execute(youTube, url);
            
            Console.ReadLine();



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDowload
{
    internal class ReceiverGetInfo
    {
        public async void Operation(YoutubeClient youtube, string videoUrl)
        {

            var video = await youtube.Videos.GetAsync(videoUrl);
            Console.WriteLine($"Название видео: {video.Title}\nОписание: {video.Description}");
        }
    }
}

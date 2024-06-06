using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDowload
{
    internal class ReceiverDowload
    {
        public async void Operation(YoutubeClient youtube, string videoUrl)
        {
            try
            {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
                await Console.Out.WriteLineAsync("Скачивание произошло умпешно");
            }
            catch 
            {
                await Console.Out.WriteLineAsync("Возникла ошибка при скачивании");
            }
            
        }
    }
}

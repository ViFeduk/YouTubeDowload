using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDowload
{
    internal class GetInfoCommand : ICommand
    {
        private ReceiverGetInfo _receiver;
        public GetInfoCommand(ReceiverGetInfo getInfo)
        {
            _receiver = getInfo;
        }
        public void Cansel()
        {
            throw new NotImplementedException();
        }

        

        public void Execute(YoutubeClient youtube, string videoUrl)
        {
            _receiver.Operation(youtube, videoUrl);
        }
    }
}

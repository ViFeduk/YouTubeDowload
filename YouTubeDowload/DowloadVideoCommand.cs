using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDowload
{
    internal class DowloadVideoCommand : ICommand
    {
        private ReceiverDowload _receiver;
        public DowloadVideoCommand(ReceiverDowload receiverDowload)
        {
            _receiver = receiverDowload;
        }
        public void Cansel()
        {
            
        }

        public void Execute(YoutubeClient youtube, string videoUrl)
        {
            _receiver.Operation( youtube,videoUrl);
        }
    }
}

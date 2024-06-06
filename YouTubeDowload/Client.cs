using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDowload
{
    internal class Client
    {
        private ICommand _command;
        public Client()
        {
            
        }
        public void SetCommand(ICommand command)
        {
            _command  = command;
        }

        public void Execute(YoutubeClient youtube, string videoUrl)
        {
            _command.Execute(youtube, videoUrl);
        }
        public void Cansel()
        {
            _command.Cansel();
        }
    }
}

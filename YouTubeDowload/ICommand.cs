using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDowload
{
    internal interface ICommand
    {
        void Execute(YoutubeClient youtube, string videoUrl);
        void Cansel();
    }
}

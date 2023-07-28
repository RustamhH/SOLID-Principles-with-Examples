using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Single_Responsibility
{
    internal class SingerG
    {
        public void Sing()
        {
            Console.WriteLine("🎶🎵");
        }

        public void WriteSongs()
        {
            Console.WriteLine("I'm writing songs of my album");
        }
    }

    // Every class (function) should do one job

    internal class Producer
    {
        public void PublishSong()
        {
            Console.WriteLine("I'm publishing the song");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Single_Responsibility
{
    internal class SingerB
    {
        public void Sing()
        {
            Console.WriteLine("🎶🎵");
        }

        public void WriteSongs()
        {
            Console.WriteLine("I'm writing songs of my album"); 
        }


        // Singer contains a function that is not its responsibility

        public void PublishSong()
        {
            Console.WriteLine("I'm publishing the song");
        }
    }














}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330051
{
    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;


        public SayaTubeVideo(String title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"playCount: {playCount}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330051
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public int getPlayCount() => playCount;
        public string getTitle() => title;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Judul video tidak boleh null dan maksimal 100 karakter");
            Random r = new Random();
            this.id = r.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 25000000)
            {
                throw new ArgumentException("Jumlah play count maksimal adalah 25.000.000 per panggilan");
            }
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
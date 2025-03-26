using modul6_103022330051;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330051
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            Debug.Assert(!string.IsNullOrEmpty(username) && username.Length <= 100, "Nama username tidak boleh null dan maksimal 100 karakter");
            Random r = new Random();
            this.id = r.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentException("Video tidak boleh null.");
            }
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User: {username}");
            int count = 1;
            for (int i = 0; i < Math.Min(uploadedVideos.Count, 10); i++)
            {
                Console.WriteLine($"Video{count} Judul: {uploadedVideos[i].getTitle()}");
                count++;
            }
        }
    }
}
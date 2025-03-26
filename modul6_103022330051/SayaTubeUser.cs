using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330051
{
    public class SayaTubeUser
    {
        private int id;
        private string Username;
        private List<SayaTubeUser> uploadedVideos;
        
        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeUser>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            { 
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}

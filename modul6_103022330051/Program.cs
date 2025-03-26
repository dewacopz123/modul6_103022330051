using modul6_103022330051;
using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("ZAKY");

        string[] filmList =
        {
            "1","2","3","4","5","6","7","8","9","10"
        };

        foreach (var title in filmList)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}
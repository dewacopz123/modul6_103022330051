using modul6_103022330051;

class program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Zaky");
        List<string> video = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        foreach (var film in video)
        {
            SayaTubeVideo video1 = new SayaTubeVideo(film);
            user.AddVideo(video1);
            video1.PrintVideoDetails();
        }

        user.PrintAllVideoPlayCount();
    }
}

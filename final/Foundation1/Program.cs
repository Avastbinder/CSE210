using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("House tour!!", "Mclovin", 1306);
        video1.AddComment("TerrariaGamer69", "Nice house!!");
        video1.AddComment("PessyThePessimist", "Your house is kinda dumb.");
        video1.AddComment("ThatDude26", "I like your backyard man!");
        videos.Add(video1);

        Video video2 = new Video("Horror game tuesday!", "EpicGamer17", 648);
        video2.AddComment("TerrariaGamer69", "Scary!!");
        video2.AddComment("PessyThePessimist", "This game seems kinda boring.");
        video2.AddComment("ThatDude26", "duuuude I gotta play this");
        video2.AddComment("scarygamewatcher", "jumpscare at 0:39");
        video2.AddComment("FieroGuy", "cmon man atleast put a jumpscare warning");
        videos.Add(video2);

        Video video3 = new Video("Infected | dev log #37", "MarkTheProgrammer", 970);
        video3.AddComment("TerrariaGamer69", "Awesome to see the progress!!");
        video3.AddComment("PessyThePessimist", "Progress has been way too slow!!");
        video3.AddComment("ThatDude26", "nice bro cant wait to play this");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            video.DisplayCommentInfo();
        }
    }
}
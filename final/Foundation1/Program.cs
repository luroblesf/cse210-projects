using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("Best WaterParks in The US: 10 Best Water parks in USA", "US Historians", 783);

        Comment video1Comment1 = new Comment("@MrMywildside", "I loved Water World!.");
        Comment video1Comment2 = new Comment("@Phuong Nguyen", "Congrats for another amazing video with pretty views as always , thanks for sharing my friend :).");
        Comment video1Comment3 = new Comment("@betogarcia9304", "Wild waves water park in washington should be on the list.");
        Comment video1Comment4 = new Comment("@mitchellries256", "Not bad but there were quite a few waterparks that weren't on the list but either should've or deserved an honorable mention such as DreamWorks Waterpark, Wilderness Resort, Raging Waters San Diemas, Splish Splash Long Island.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);
        video1.ListComment(video1Comment4);

        videosList.Add(video1);

        Video video2 = new Video("Full Workout", "HIGH Fitness", 360);

        Comment video2Comment1 = new Comment("@skdll7029", "Such a fun playlist! Thanks for adding another one!");
        Comment video2Comment2 = new Comment("@haileylarsen8952", "so excited to get a new playlist!!! Love working out with you guys! Thanks for such fun energy and great music!.");
        Comment video2Comment3 = new Comment("@user-dm8po2ky7q", "Please post more like this!! And more often!");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);


        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
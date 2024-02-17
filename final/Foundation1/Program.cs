using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("An Invitation to Come Unto Christ", "Church of Jesus Christ | Come Unto Christ", 89);

        Comment video1Comment1 = new Comment("@JuliePetracca", "Thank you Jesus christ for the support you give me. THSNK YOU  for all the blessings you give me.");
        Comment video1Comment2 = new Comment("@pamweinberg1212", "Thank you for a beautiful message.");
        Comment video1Comment3 = new Comment("@daoudfoster3760", "Thank you ABBA, simple yet powerful.");

        video1.ListComment(videoComment1);
        video1.ListComment(videoComment2);
        video1.ListComment(videoComment3);

        videosList.Add(video1);

        Video video2 = new Video("An Invitation to Come Unto Christ", "Church of Jesus Christ | Come Unto Christ", 89);

        Comment video2Comment1 = new Comment("@JuliePetracca", "Thank you Jesus christ for the support you give me. THSNK YOU  for all the blessings you give me.");
        Comment video2Comment2 = new Comment("@pamweinberg1212", "Thank you for a beautiful message.");
        Comment video2Comment3 = new Comment("@daoudfoster3760", "Thank you ABBA, simple yet powerful.");

        video2.ListComment(videoComment1);
        video2.ListComment(videoComment2);
        video2.ListComment(videoComment3);

        videosList.Add(video2);

        
        Video video2 = new Video("An Invitation to Come Unto Christ", "Church of Jesus Christ | Come Unto Christ", 89);

        Comment video2Comment1 = new Comment("@JuliePetracca", "Thank you Jesus christ for the support you give me. THSNK YOU  for all the blessings you give me.");
        Comment video2Comment2 = new Comment("@pamweinberg1212", "Thank you for a beautiful message.");
        Comment video2Comment3 = new Comment("@daoudfoster3760", "Thank you ABBA, simple yet powerful.");

        video2.ListComment(videoComment1);
        video2.ListComment(videoComment2);
        video2.ListComment(videoComment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            SetVideo.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("The Art of Selling Paper:", "Michael Scott", 480);

        Comment video1Comment1 = new Comment("Johnathan", "This video is truly inspiring!");
        Comment video1Comment2 = new Comment("Marko", "Your content always surprises me.");
        Comment video1Comment3 = new Comment("Taylor", "Wonderful! I would love to visit Scranton someday.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("The Secret to making chili:", "Kevin Malone", 975);

        Comment video2Comment1 = new Comment("Dante", "What a great watch, makes me hungry.");
        Comment video2Comment2 = new Comment("Grace", "Your videos always make me want to try these recipes.");
        Comment video2Comment3 = new Comment("Tammy", "I'm not a fan of chili.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Beet Farming 101:", "Dwight Schrute", 650);

        Comment video3Comment1 = new Comment("Gabby", "How does one get started in the field of beet farming?");
        Comment video3Comment2 = new Comment("chris", "I love beets, what's you favorite way to eat them?");
        Comment video3Comment3 = new Comment("Franky", "Beets are terrible, why don't you grow other things?");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
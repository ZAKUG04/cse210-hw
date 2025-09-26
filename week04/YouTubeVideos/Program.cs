using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Epic Rocket League Goals", "NefiPlays", 720);
        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Bro that play was insane "));
        video1.AddComment(new Comment("Andrew", "Please upload more Rocket League videos!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to Grow Fast on YouTube", "CreatorTips", 850);
        video2.AddComment(new Comment("Diana", "Thanks, I really needed this advice."));
        video2.AddComment(new Comment("Peter", "Very clear, Ill start applying this today."));
        video2.AddComment(new Comment("Martha", "I wishI had seen this earlier."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Cute Cats Compilation 2025", "CatWorld", 480);
        video3.AddComment(new Comment("George", "That white kitten stole my heart"));
        video3.AddComment(new Comment("Hannah", "Haha the one at 2:15 is hilarious."));
        video3.AddComment(new Comment("Paula", "I need a cat like that in my life"));
        videos.Add(video3);

        // show the info
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
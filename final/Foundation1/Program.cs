using System;

class Program
{
    static void Main(string[] args)
    {        
        //Create 3-4 videos, set the values, and then add 3-4 comments for each
        //Store videos in a list
        //Display each video's title, author, length, number of comments, and then list the comment
        List<Video> videos = new List<Video>();

        Video video1 = new Video("We went to Japan for a week with no money!", "Mark", 650);
        video1.AddComment(new Comment("SmartGuy314", "I can't believe you ate raw sushi like that!"));
        video1.AddComment(new Comment("KidFromNewYork92", "First"));
        video1.AddComment(new Comment("JohnTVolt", "I would never fly business class like that. I only take 1st class."));
        videos.Add(video1);

        Video video2 = new Video("Master Chief teaches you how to change the oil on your 2008 Scion XD", "Pibbles", 430);
        video2.AddComment(new Comment("WildChild21", "My car doesn't have an oil cap. My cap says 710. Help!!"));
        video2.AddComment(new Comment("MasterBlaster18", "Very informative. Thank you!"));
        video2.AddComment(new Comment("AnimeEnthusiast1234", "You should be a voice actor!"));
        videos.Add(video2);

        Video video3 = new Video("How to get women to like you in 62 seconds!", "PopularKid", 61);
        video3.AddComment(new Comment("BigBawler982", "I tried your strategy, but the girl just laughed at me."));
        video3.AddComment(new Comment("OnlineDude109", "No Way! That's the school I go to!"));
        video3.AddComment(new Comment("WatchDog90", "First"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
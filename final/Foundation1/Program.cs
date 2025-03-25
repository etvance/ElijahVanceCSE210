using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("The PERFECT Gamble:", "Lazy Mattman", 1667);
        Comment v1c1 = new Comment("@dmitryyarlykov5782", "2:17 Mattman forgetting he has Callus to walk on the spikes is truly a Mattman moment");
        Comment v1c2 = new Comment("@leviswabyisme", "You cannot escape me, Matthew. Tainted Jacob. Chest. Tomorrow. I shall tune in post haste");
        Comment v1c3 = new Comment("@infernodragon4real375", "Don't forget it, Matthew. 6:42 PM. October 1st. Olive Garden. Take the Cheese Grater");
        Comment v1c4 = new Comment("@RenoKyrie", "What you missed about reworked Lil Portal is its BASICALLY Moving Box but as a Passive item");
        v1.AddComment(v1c1);
        v1.AddComment(v1c2);
        v1.AddComment(v1c3);
        v1.AddComment(v1c4);

        Video v2 = new Video("I put jet engines on a SLED and broke a WORLD RECORD", "Hacksmith Industries", 1631);
        Comment v2c2 = new Comment("@lord_kerman", "Mike: 'You would have to be crazy to pilot something like this' \nJames: '...hold my maple syrup'");
        Comment v2c3 = new Comment("@pux0rb", "This is probably the most Canadian thing I've ever seen, and I love it!");
        Comment v2c4 = new Comment("@GeeMannn", "Thank you for feeding my addiction to watching people stick jet engines to random stuff.");
        v2.AddComment(v2c2);
        v2.AddComment(v2c3);
        v2.AddComment(v2c4);

        Video v3 = new Video("How Hollow Knight Changed Me...", "Dragoon", 2862);
        Comment v3c1 = new Comment("@ricodo1244", "You didn't get the geo rock on the left of your spawn at 0:11 unwatchable Video.");
        Comment v3c2 = new Comment("@Veli_Nikels", "I spent 20 minutes trying to make a function for dragoon's growth but I couldn't do it...");
        Comment v3c3 = new Comment("@notbot0123", "him ACTUALLY using dreamshield for so long caused me PHYSICAL PAIN");
        Comment v3c4 = new Comment("@user-gt5fy5ow4i", "Dragoon is my favorite 30 story tall youtuber");
        v3.AddComment(v3c1);
        v3.AddComment(v3c2);
        v3.AddComment(v3c3);
        v3.AddComment(v3c4);

        List<Video> allVideos = new List<Video>()
        {
            v1,v2,v3
        };

        foreach (Video x in allVideos)
        {
            x.DisplayVideoInfo();
            int count = x.CountComments();
            Console.WriteLine($"This video has {count} comments: \n");
            x.ListComments();

            Console.WriteLine("--------------------------------------");
        }
    }
}
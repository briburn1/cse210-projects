using System;

class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("How To Perform Lower Quarter Dermatome Testing", "Han Solo", 120);
        
        Comment c1 = new Comment("user_5", "This video was really helpful!");
        Comment c2 = new Comment("briburn84", "This video did a great job at explaining what to do!");
        Comment c3 = new Comment("user5342", "Good video!");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);

        Video v2 = new Video("How To Install a Dishwasher", "Luke Skywalker", 1977);

        Comment c4 = new Comment("groguisthebest", "Because of this video, I had no problems with installation!");
        Comment c5 = new Comment("newtodiy", "This video was extremely helpful!");
        Comment c6 = new Comment("anonymous", "He made this seem so easy!");

        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);

        Video v3 = new Video("How To Perform a Piriformis Release", "Dr. Chewie", 600);

        Comment c7 = new Comment("spt25", "Great video!");
        Comment c8 = new Comment("user_5", "I think this video did a great job at explaining how to do it!");
        Comment c9 = new Comment("user_5", "I love this video!");

        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);

        Console.WriteLine(v1.GetComment());
        v2.GetComment();
        v3.GetComment();



    }
}
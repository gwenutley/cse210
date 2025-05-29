using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.SetTitle("C# Programming");
        video1.SetAuthor("Mark Smith");
        video1.SetLength(175);

        Comment comment1 = new Comment();
        comment1.SetText("Very helpful");
        comment1.SetAuthorName("Bob Kamm");

        Comment comment2 = new Comment();
        comment2.SetText("Wow");
        comment2.SetAuthorName("Andy Miller");

        Comment comment3 = new Comment();
        comment3.SetText("Great examples");
        comment3.SetAuthorName("April Zurch");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.DisplayAllComments();
        Console.WriteLine();


        Video video2 = new Video();
        video2.SetTitle("Learn how to Program");
        video2.SetAuthor("Luke Hill");
        video2.SetLength(571);

        Comment comment4 = new Comment();
        comment4.SetText("How does that work?");
        comment4.SetAuthorName("Tom Small");

        Comment comment5 = new Comment();
        comment5.SetText("This video is great");
        comment5.SetAuthorName("Owen Hart");

        Comment comment6 = new Comment();
        comment6.SetText("Nice Work");
        comment6.SetAuthorName("Jane Webster");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.DisplayAllComments();
        Console.WriteLine();


        Video video3 = new Video();
        video3.SetTitle("Learn C#");
        video3.SetAuthor("John Jones");
        video3.SetLength(342);

        Comment comment7 = new Comment();
        comment7.SetText("Excellent");
        comment7.SetAuthorName("Matt Smith");

        Comment comment8 = new Comment();
        comment8.SetText("That video helps a lot");
        comment8.SetAuthorName("Sandy Adams");

        Comment comment9 = new Comment();
        comment9.SetText("I am learning so much!");
        comment9.SetAuthorName("Claire Olsen");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.DisplayAllComments();
        Console.WriteLine();

    }
}
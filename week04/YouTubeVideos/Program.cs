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
        video1.GetAllComments();


        Video video2 = new Video();
        video1.SetTitle("Learn how to Program");
        video1.SetAuthor("Luke Hill");
        video1.SetLength(571);

        Comment comment4 = new Comment();
        comment1.SetText("How does that work?");
        comment1.SetAuthorName("Tom Small");

        Comment comment5 = new Comment();
        comment2.SetText("This video is great");
        comment2.SetAuthorName("Owen Hart");

        Comment comment6 = new Comment();
        comment3.SetText("Nice Work");
        comment3.SetAuthorName("Jane Webster");

        video1.AddComment(comment4);
        video1.AddComment(comment5);
        video1.AddComment(comment6);
        video1.GetAllComments();


        Video video3 = new Video();
        video1.SetTitle("Learn C#");
        video1.SetAuthor("John Jones");
        video1.SetLength(342);

        Comment comment7 = new Comment();
        comment1.SetText("Excellent");
        comment1.SetAuthorName("Matt Smith");

        Comment comment8 = new Comment();
        comment2.SetText("That video helps a lot");
        comment2.SetAuthorName("Sandy Adams");

        Comment comment9 = new Comment();
        comment3.SetText("I am learning so much!");
        comment3.SetAuthorName("Claire Olsen");

        video1.AddComment(comment7);
        video1.AddComment(comment8);
        video1.AddComment(comment9);
        video1.GetAllComments();

    }
}
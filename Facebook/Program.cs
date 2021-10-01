using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("Ayshan", "Ganbarli");
            User u2 = new User("Bashir", "Azizov", 21);

            

            Post p1 = new Post();
            p1.Text = "Flower";
            p1.CommentCount = 105;
            p1.LikeCount = 30;
            p1.SharedDate = "27.09.2021";

            Post p2 = new Post();
            p2.Text = "Fashion";
            p2.CommentCount = 500;
            p2.LikeCount = 2000;

            Post[] Posts = { p1, p2 };
            u1.Posts = Posts;


            Comment c1 = new Comment();
            c1.Text = Console.ReadLine();
            c1.CommentedDate = "29.09.2021";

            Comment c2 = new Comment();
            c2.Text = Console.ReadLine();
            c2.CommentedDate = "28.09.2021";

            Comment[] Comments = { c1, c2 };
            p1.Comments = Comments;

            c1.user = new User();
            

        }
    }
}

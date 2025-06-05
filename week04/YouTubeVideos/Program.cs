using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("How to Learn Programming in 30 Days", "João Silva", 240);
            Video video2 = new Video("Tips to Improve Your English Quickly", "Larissa Pereira", 300);
            Video video3 = new Video("How to Organize Your Study Routine", "Rafael Lima", 180);
            Video video4 = new Video("Healthy Eating for Beginners", "Camila Santos", 180);
            video._comment = new List<Comment>
            {
                new Comment("Ana Souza", "I loved João's approach! The tips are super practical and easy to follow."),
                new Comment("Carlos Oliveira", "I'm already on my second day of the course, and everything has been making sense so far. Thank you!"),
                new Comment("Maria Lima", "The video has a lot of valuable information, but I wish there were more examples throughout the explanation."),
                new Comment("Felipe Martins", "Great content! I just think the video could be a bit shorter to keep attention better.")
             };

            video2._comment = new List<Comment>
            {
                new Comment("Juliana Costa", "The tips are great, Larissa! I’ll start practicing every day, no doubt!"),
                new Comment("Lucas Almeida", "I liked the active listening techniques. I’ll try to apply them in my daily routine."),
                new Comment("Gabriel Rocha", "This video really helped, but I think it could include more tips for beginners."),
                new Comment("Beatriz Gomes", "I already use some of these tips, and they really work! Totally worth it.")
            };

            video3._comment = new List<Comment>
            {
                new Comment("Fernanda Barbosa", "So good! Now I can plan my schedule better and study more efficiently."),
                new Comment("Thiago Martins", "Rafael has a great teaching style, the tips are direct and easy to understand."),
                new Comment("Luciana Silva", "The suggested tools for organization are great. I’ll try using Trello."),
                new Comment("Ricardo Costa", "The video was helpful, but it could include more practical examples of how to set up the routine.")

            };

            video4._comment = new List<Comment>
            {
                new Comment("Tatiane Melo", "This video was amazing! I learned so much about how to start eating healthier."),
                new Comment("Eduardo Ferreira", "Loved the recipes you shared! I’m going to try making that salad for lunch."),
                new Comment("Mariana Alves", "It would be great if you talked a bit more about supplements and essential vitamins."),
                new Comment("Carlos Henrique", "Really good, Camila! I just had a question about meal timing.")
            };



           // video.AddComment(new Comment("Ana Souza", "I loved João's approach! The tips are super practical and easy to follow."));
           // video.AddComment(new Comment("Carlos Oliveira", "I'm already on my second day of the course, and everything has been making sense so far. Thank you!"));
          //  video.AddComment(new Comment("Maria Lima", "The video has a lot of valuable information, but I wish there were more examples throughout the explanation."));
           // video.AddComment(new Comment("Felipe Martins", "Great content! I just think the video could be a bit shorter to keep attention better."));
         
           

          //  video2.AddComment(new Comment("Juliana Costa", "The tips are great, Larissa! I’ll start practicing every day, no doubt!"));
          //  video2.AddComment(new Comment("Lucas Almeida", "I liked the active listening techniques. I’ll try to apply them in my daily routine."));
          //  video2.AddComment(new Comment("Gabriel Rocha", "This video really helped, but I think it could include more tips for beginners."));
          //  video2.AddComment(new Comment("Beatriz Gomes", "I already use some of these tips, and they really work! Totally worth it."));
       

          //  video3.AddComment(new Comment("Fernanda Barbosa", "So good! Now I can plan my schedule better and study more efficiently."));
          //  video3.AddComment(new Comment("Thiago Martins", "Rafael has a great teaching style, the tips are direct and easy to understand."));
          //  video3.AddComment(new Comment("Luciana Silva", "The suggested tools for organization are great. I’ll try using Trello."));
          //  video3.AddComment(new Comment("Ricardo Costa", "The video was helpful, but it could include more practical examples of how to set up the routine."));
            

          //  video4.AddComment(new Comment("Tatiane Melo", "This video was amazing! I learned so much about how to start eating healthier."));
          //  video4.AddComment(new Comment("Eduardo Ferreira", "Loved the recipes you shared! I’m going to try making that salad for lunch."));
         //   video4.AddComment(new Comment("Mariana Alves", "It would be great if you talked a bit more about supplements and essential vitamins."));
         //   video4.AddComment(new Comment("Carlos Henrique", "Really good, Camila! I just had a question about meal timing."));
           
       


            List<Video> listOfVideos = new List<Video>();
            listOfVideos.Add(video);
            listOfVideos.Add(video2);
            listOfVideos.Add(video3);
            listOfVideos.Add(video4);

            foreach(Video vide in listOfVideos)
            {
                Console.WriteLine($"\n\n{vide.GetTitle()} - {vide.GetAuthor()} - {vide.GetLength()} seconds - {vide.GetNumComments()} comments:\n");
                vide.DisplayInf();
            }

            Console.ReadKey();
        }
    }

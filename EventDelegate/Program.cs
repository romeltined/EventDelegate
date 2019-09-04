using System;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            News news = new News();
            news.Title = "Manila Times";

            Publisher publisher = new Publisher();

            Subscriber subscriber = new Subscriber();

            publisher.NewsPublished += subscriber.OnNewsPublished;
            publisher.Publish(news);


        }
    }
}



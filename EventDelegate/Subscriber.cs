using System;

namespace EventDelegate
{
    public class Subscriber
    {
        public void OnNewsPublished(object sender, NewsEventArgs e)
        {
            Console.WriteLine("The subscriber received the news called: {0}", e.News.Title);
        }
    }
}



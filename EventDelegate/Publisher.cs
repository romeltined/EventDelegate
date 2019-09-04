using System;
using System.Threading;

namespace EventDelegate
{
    public class Publisher
    {
        public event EventHandler<NewsEventArgs> NewsPublished;
        public void Publish(News news)
        {
            System.Console.WriteLine("Publishing the news: {0}", news.Title);
            Thread.Sleep(3000);
            OnNewsPublished(news);
        }

        protected virtual void OnNewsPublished(News news)
        {
            NewsPublished?.Invoke(this, new NewsEventArgs() { News = news });
        }
    }
}



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweet
{
    static class TweetManager
    {
        private static List<Tweet> TWEETS = new List<Tweet> { };
        private static string FILENAME= "Assignment_02_TweetFile.txt";

        static TweetManager()
        {
            StreamReader streamReader = new StreamReader(FILENAME);
            String line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Tweet t = Tweet.Parse(line);
                TWEETS.Add(t);
            }
        }

        public static void Initialize()
        {
            Tweet t1 = new Tweet("Raptors","Drake","Obama","Go Raptors! Go!");
            Tweet t2 = new Tweet("Raptors", "Drake", "Obama", "Go Raptors! Go!");
            Tweet t3 = new Tweet("Raptors", "Drake", "Obama", "Go Raptors! Go!");
            Tweet t4 = new Tweet("Raptors", "Drake", "Obama", "Go Raptors! Go!");
            Tweet t5 = new Tweet("Raptors", "Drake", "Obama", "Go Raptors! Go!");
            TWEETS.Add(t1);
            TWEETS.Add(t2);
            TWEETS.Add(t3);
            TWEETS.Add(t4);
            TWEETS.Add(t5);
        }

        public static void ShowAll()
        {
            foreach (Tweet t in TWEETS)
            {
                Console.WriteLine(t);
            }
        }

        public static void ShowAll(string tag)
        {
            foreach (Tweet t in TWEETS)
            {
                if (t.Tag.ToLower().Equals(tag))
                {
                    Console.WriteLine(t);
                }
                
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweet
{
    class Tweet
    {
        private static int CURRENT_ID = 1;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from, string to, string body, string tag)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            Id = Convert.ToString(CURRENT_ID);
            CURRENT_ID++;
        }

        public Tweet(string from, string to, string body, string tag, string id)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Tweeted by {From}\n tweet content: { (Body.Length < 40 ? Body : Body.Substring(0, 40))} \n Reciever: {To}\n tag: #{Tag} \nID: {Id} \n\n ";
        }

        public static Tweet Parse(string line)
        {
            String[] separator = line.Split(new char[] { '\t' });
            String[] separator1 = separator[3].Split(' ');
            String[] body = separator1.Take(separator1.Length - 1).ToArray();
            String body1 = string.Join(" ", body);
            Tweet t = new Tweet(separator[1], separator[2], body1, separator[0], separator1[separator1.Length - 1]);
            return t;
        }
    }
}

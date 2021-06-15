using System;
using System.Collections.Generic;

using System.Web.Script.Serialization;   //for the serialize
using System.IO;                         //for file io 

namespace LizardDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lizard lizard = new Lizard { Age = 2, Color = LizardColor.Black, Name = "Gecko" };
            //Console.WriteLine(lizard);

            //SerializeOneLizard("one.json");
            DeserializeOneLizard("one.json");
        }
        static void SerializeLizards(string filename)
        {
            List<Lizard> lizards = new List<Lizard>
            {
                new Lizard { Age = 2, Color = LizardColor.Black, Name = "Gecko" },
                new Lizard { Age = 1, Color = LizardColor.Green, Name = "Komodo" }
            };
        }
        static void DeserializeOneLizard(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Lizard liz = serializer.Deserialize<Lizard>(reader.ReadToEnd());
                Console.WriteLine($"the recoverd object is {liz}");
            }
        }
        static void SerializeOneLizard(string filename)
        {
            Lizard lizard = new Lizard { Age = 2, Color = LizardColor.Black, Name = "Gecko" };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string output = serializer.Serialize(lizard);
            TextWriter writer = new StreamWriter(filename);
            writer.Write(output);
            writer.Close();
        }
    }

    enum LizardColor { Black, Green, Brown}
    class Lizard
    {
        public string Name { get; set; }
        public LizardColor Color { get; set; } 
        public int Age { get; set; }
        public override string ToString()
        {
            return $"I am a {Age}yrs {Color} {Name}";
        }
    }
}

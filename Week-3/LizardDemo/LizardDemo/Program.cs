using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.IO;

namespace LizardDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lizard lizard = new Lizard { Age = 3, color = LizardColor.Lime,  Name = "Gecko"};

            //DesirializeOneLizard("File.json");
            Serialization("File.json");
        }

        static void DesirializeOneLizard(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Lizard liz = serializer.Deserialize<Lizard>(reader.ReadToEnd());
                Console.WriteLine($"the recovered object is {liz}");
            }
        }
        static void Serialization(string filename)
        {

            TextWriter writer = new StreamWriter(filename);

            Lizard lizard = new Lizard { Age = 3, color = LizardColor.Lime, Name = "Jio" };

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string output = serializer.Serialize(lizard);

            writer.Write(output);
            writer.Close();



            //Lizard lizard = new Lizard { Age = 3, color = LizardColor.Lime, Name = "Gecko" };
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //string output = serializer.Serialize(lizard);
            //TextWriter writer = new StreamWriter(filename);
            //writer.Write(output);
            //writer.Close();
        }
    }

    enum LizardColor { Black, Green, Brown, Lime}
    class Lizard
    {
        public string Name { get; set; }
        public LizardColor color { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name is {Name} and age is {Age} and color is {color}";
        }
    }
}

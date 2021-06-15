using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeOneLizard("one.json");

            DeSerializeOneLizard("one.json");

            SerializeLizards("multiple.json");

            DeSerializeLizards("multiple.json");

        }

        //Serialize one Lizard
        static void SerializeOneLizard(string fileName)
        {
            TextWriter writer = new StreamWriter(fileName);
            
            Lizard lizard = new Lizard { Age = 3, Color = LizardColor.Blue, Name = "Jio" };

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string output = serializer.Serialize(lizard);

            writer.Write(output);
            writer.Close();
            Console.WriteLine($"Serialize one Lizard\n");
        }

        //DeSerialize one Lizard
        static void DeSerializeOneLizard(string fileName)
        {
            using (TextReader reader = new StreamReader(fileName)) {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Lizard liz = serializer.Deserialize<Lizard>(reader.ReadToEnd());
                Console.WriteLine($"DeSerialize one Lizard\n");
                Console.WriteLine(liz);
            }
        }

        //Serialize multiple Lizard
        static void SerializeLizards(string fileName)
        {
            List<Lizard> lizards = new List<Lizard> {

                new Lizard { Age = 1, Color = LizardColor.Red, Name = "James" },
                new Lizard { Age = 2, Color = LizardColor.Blue, Name = "Rick" },
                new Lizard { Age = 3, Color = LizardColor.Green, Name = "Watson" }
            };
            
            TextWriter writer = new StreamWriter(fileName);


            JavaScriptSerializer serializer = new JavaScriptSerializer();

            writer.Write(serializer.Serialize(lizards));
            writer.Close();

            Console.WriteLine($"Serialize Multiple Lizard\n");
        }

        //DeSerialize multiple Lizard
        static void DeSerializeLizards(string fileName)
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                List<Lizard> liz = serializer.Deserialize<List<Lizard>>(reader.ReadToEnd());
                Console.WriteLine($"DeSerialize multiple Lizard\n");
                foreach (Lizard x in liz)
                {
                    Console.WriteLine(x);
                }
            }
        }


    }

    enum LizardColor { Black, Red, Green, Yellow, Blue, White, Brown}

    class Lizard
    {
        public string Name { get; set; }
        public LizardColor Color { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"I am a {Age} yrs old {Color} in colour";
        }

        
    }
}

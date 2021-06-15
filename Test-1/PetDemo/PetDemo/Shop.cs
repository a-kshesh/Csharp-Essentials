using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PetDemo
{
    class Shop
    {
        private List<Pet> pets = new List<Pet> {};
       
        int index = 1;
        public Shop()
        {
            pets = new List<Pet> { };
        }

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }
        public void show()
        {
            foreach (Pet p in pets)
            {
                Console.WriteLine(index + " " + p);
                index++;
            }
            index = 1;
        }

        public void show(bool IsNeutered)
        {
            foreach (Pet p in pets)
            {
                if (p.IsNeutered)
                {
                    Console.WriteLine(index + " " + p);
                    index++;
                }
            }
            index = 1;
        }

        public void show(Gender gender)
        {
            foreach (Pet p in pets)
            {
                if (gender==p.Gender)
                {
                    Console.WriteLine(index + " " + p);
                    index++;
                }
            }
            index = 1;
        }
        public void show(int month)
        {
            foreach (Pet p in pets)
            {
                if (p.Age.Month >= month)
                {
                    Console.WriteLine(index + " " + p);
                    index++;
                }
            }
            index = 1;
        }

        public void show(Double weight)
        {
            foreach (Pet p in pets)
            {
                if (p.Weight <= weight)
                {
                    Console.WriteLine(index + " " + p);
                    index++;
                }
            }
            index = 1;
        }

        public void Save(String filename)
        {
           
            TextWriter writer = new StreamWriter(filename);
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string output = serializer.Serialize(pets);

            writer.Write(output);
            writer.Close();
            
        }
    }

}

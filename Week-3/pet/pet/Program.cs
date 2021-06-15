using System;
using System.Collections.Generic;

namespace pet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pet pet1 = new Pet("leo", 8, "Bull Dog");
            Pet pet2 = new Pet("Oscar", 5, "Pug");
            Pet pet3 = new Pet("kai", 6, "Labradar");
            Pet pet4 = new Pet("tom", 7, "Husky");

            pet1.SetOwner("Ashish");
            pet1.train();
            pet2.SetOwner("Akshesh");
            pet2.train();
            pet3.SetOwner("Yash");
            pet3.train();
            pet4.SetOwner("Shruthi");
            pet4.train();

            
            List<Pet> Pet = new List<Pet>();
            Pet.Add(pet1);
            Pet.Add(pet2);
            Pet.Add(pet3);
            Pet.Add(pet4);
            Console.WriteLine(pet1);
            Console.WriteLine(pet2);
            Console.WriteLine(pet3);
            Console.WriteLine(pet4);

            foreach (Pet p in Pet)
            {
                if (p.Owner.Equals("Akshesh"))
                {
                    Console.WriteLine($"Owner of {p.Name} is {p.Owner}");
                }            
}


        }
    }

    class Pet
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }


        public Pet(string name,int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
            this.Owner = "No one";
            this.IsHouseTrained = false;
        }
        public override string ToString()
        {
            return $"{Name},{Age},{Description},{Owner},{IsHouseTrained}";
        }
        public void SetOwner(string owner)
        {
            this.Owner = owner;
        }
        public void train()
        {
            IsHouseTrained = true;
        }
        


    }
}

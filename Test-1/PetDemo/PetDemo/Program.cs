using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Console.WriteLine("Checking pet constructor");
            Pet pet = new Pet("cat", new Age(3, 10), 3.4, Gender.Female);
            Console.WriteLine(pet);
            Console.WriteLine($"Invoking the Neuter() method");
            pet.Neuter();
            Console.WriteLine(pet);

            Pet pet1= new Pet("Dog", new Age(5, 10), 9, Gender.Male);
            Pet pet2 = new Pet("cat", new Age(11, 0), 10, Gender.Female);
            Pet pet3 = new Pet("Kangaroo", new Age(12, 10), 11, Gender.Male);
            Pet pet4 = new Pet("Lion", new Age(5, 10), 15, Gender.Female);
            Pet pet5 = new Pet("Tiger", new Age(15, 10), 11, Gender.Female);
            Pet pet6 = new Pet("Camel", new Age(3, 10), 25, Gender.Male);
            Pet pet7 = new Pet("Horse", new Age(3, 10), 30, Gender.Neutral);
            Pet pet8 = new Pet("Squirrel", new Age(6, 10), 3, Gender.Neutral);
            Pet pet9 = new Pet("Buffelo", new Age(5, 10), 50, Gender.Male);
            Pet pet10 = new Pet("Cow", new Age(22, 10), 55, Gender.Female);
            shop.AddPet(pet);
            shop.AddPet(pet1);
            shop.AddPet(pet2);
            shop.AddPet(pet3);
            shop.AddPet(pet4);
            shop.AddPet(pet5);
            shop.AddPet(pet6);
            shop.AddPet(pet7);
            shop.AddPet(pet8);
            shop.AddPet(pet9);
            shop.AddPet(pet10);

            pet4.Neuter();
            pet6.Neuter();
            pet8.Neuter();
            pet10.Neuter();


            //To show all pets in shop (code required)
            Console.WriteLine($"\n\nAll pets:");
            
            shop.show();

            //To show all neutered pets in shop (code required) bool isNeutered = true;
            Console.WriteLine($"\n\nAll pets that are neutered"); 
            shop.show(true);

            //To show all male pets in shop (code required) Gender gender = Gender.Male;
            Console.WriteLine($"\n\nAll {Gender.Male} pets");
            shop.show(Gender.Male);

            //To show all pets older than 2mos in shop (code required) int month = 2;
            Console.WriteLine($"\n\nAll pets {10}mos or older");
            shop.show(10);
            //To show all pets weighing less than 1kg in shop (code required) double kg = 1; 
            Console.WriteLine($"\n\nAll pets less than {8}kg");
            shop.show(8);

            String filename = "pets.jason";
            //To saving all pets to a json file (code required) string file = "pets.json";
            Console.WriteLine($"\n\nSaving all pets to file {filename}");
            shop.Save(filename);
        }
    }
}

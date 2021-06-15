using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Pet
    {
        public Age Age { get; }
        public Gender Gender { get; }
        public String Name { get; }
        public double Weight { get; }
        public bool IsNeutered { get; private set; }

        public Pet(String name,Age age,double weight,Gender gender,bool isNeutered=false)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Gender = gender;
            IsNeutered = isNeutered;
        }

        public void Neuter()
        {
            IsNeutered = true;
        }

        public override string ToString()
        {
            return $" {Name}, {Age} , {Weight} kg, {Gender}, {(IsNeutered? "Neutered":"")}";
        }
    }
}

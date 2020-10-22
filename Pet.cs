using System;
using System.Collections.Generic;

namespace Unit3Quiz1
{
    public class Pet
    {
         public Pet(string nameArg, string petKindArg, string sexArg, int ageArg, string breedArg, bool snArg) {
            Name = nameArg;
            PetKind = petKindArg;
            Sex = sexArg;
            Age = ageArg;
            Breed = breedArg;
            IsSpayedNeutered = snArg;
            IsAdopted = false;
        }

        // Pet data members go here
        public string Name { get; private set; }
        public string PetKind { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
        public string Breed { get; private set; }
        protected bool IsSpayedNeutered;
        protected bool IsAdopted;

        public override string ToString() {
            string result = $"Name of pet: {Name}\n";
            result += $"Type of pet: {PetKind}\n";
            result += $"Pet sex: {Sex}\n";
            result += $"Pet age: {Age}\n";
            result += $"Breed of pet: {Breed}\n";
            return result;
        }

    }
}
using System;
using System.Collections.Generic;

namespace Unit3Quiz1
{
    public class AnimalShelter {
        
        public AnimalShelter() {
            // Create empty list
            _pets = new List<Pet>();

            // Create pet list 
            var pet1 = new Pet("Charli", "Cat", "Female", 3, "Domestic Short Hair", true);
            var pet2 = new Pet("Athena", "Puppy", "Male", 1, "Border Collie", false);
            var pet3 = new Pet("Walker", "Dog", "Female", 2, "Alaskan Husky", true);
            var pet4 = new Pet("Mosby", "Rabbit", "Male", 1, "Rex", false);

            // Add pets to pet Collections
            _pets.Add(pet1);
            _pets.Add(pet2);
            _pets.Add(pet3);
            _pets.Add(pet4);
            
        }

        // Data member to represent Pet Collections
        private List<Pet> _pets;
        

        // Print all the pets
        public List<Pet> GetAllPets() {
            return _pets;
        }
        
        // Search for pet
        public Pet SearchForPet(string BreedOfPetToSearch) {
            Console.WriteLine($"Searching for Pet: {BreedOfPetToSearch}");
            for (int i = 0; i < _pets.Count; i++) {
                Pet nextPet = _pets[i];
                if (nextPet.Breed.ToLower() == BreedOfPetToSearch.ToLower()) {
                    return nextPet;
                }
            }
            return null;
        }

    }
   
}

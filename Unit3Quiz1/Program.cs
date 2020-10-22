using System;

namespace Unit3Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            // MOVIE CODE
            // var myMovie = new Movie("The Firm", "Sydney Pollack", 1993);

            // myMovie.PrintDetails();

            // int requiredRating = 5;
            // int currentRating = 0;

            // while(currentRating < requiredRating) {
            //     Console.WriteLine($"Rate this movie between 1 and 5 (inclusive)! {myMovie.Title}");
            //     string userInput = Console.ReadLine();
            //     int movieRating = 0;

            //     try {
            //         movieRating = int.Parse(userInput);
            //     } catch {
            //         Console.WriteLine("Error: Enter a number between 1 and 5 (inclusive)");
            //         continue;
            //     }
            //     try {
            //         myMovie.RateMovie(movieRating);
            //         currentRating++;
            //     } catch {
            //         Console.WriteLine($"Invalid rating {movieRating}");
            //     }

            // }
        
            // double averageRating = myMovie.GetAverageRating();
            // Console.WriteLine($"The average rating is: {averageRating}");


            // ANIMAL SHELTER CODE
            var theShelter = new AnimalShelter();

            Console.WriteLine("Welcome to ComIT Animal Shelter!");

            var allPets = theShelter.GetAllPets();
            Console.WriteLine("\n--------All Pets--------");
            foreach (var pet in allPets) {
                Console.WriteLine(pet.ToString());
            }
            Console.WriteLine("------------------------\n");

            while (true) {
                Console.WriteLine("\na - adopt a pet; r - return a pet; s - search for a pet; p - print pet list; q - quit");
                string userInput = Console.ReadLine();    

                // adopt a pet
                if (userInput == "a") {
                    
                } else {

                }

                // return a pet 
                if (userInput == "r") {

                } else {

                }

                // search for a pet 
                if (userInput == "s") {
                    Console.WriteLine("What breed of pet do you want to search for?");
                    string BreedOfPetToSearch = Console.ReadLine();
                    Pet result = theShelter.SearchForPet(BreedOfPetToSearch);

                    if (result == null) {
                        Console.WriteLine("Pet was not found!");
                    } else {
                        Console.WriteLine($"Found a pet: {result.Name}, {result.Sex}, and {result.Age} years old");
                    }

                }
             
                // quit the program 
                if (userInput == "q"){
                    break;
                }
            }
        }
    }
   
}

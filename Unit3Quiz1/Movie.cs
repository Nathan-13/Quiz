using System;
using System.Collections.Generic;

namespace Unit3Quiz1
{
    /*
   Challenge:
   - 1. Add a data member for a unique Id to the Movie class
   - 2. Add a data member for a collection of numerical ratings
   - 3. Add a constructor that initializes all the data members of a movie
   - 4. Add a method that allows you to add a rating between 1 and 5 (inclusive) to the movie
   - 5. Add a mechanism that allows you to get the average rating of a movie
   */

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
   
    public class Movie {
        static int minRating = 1;
        static int maxRating = 5;

        public int Id { get; private set;}
        public string Title { get; private set; }
        public string Director { get; private set; }
        public int Year { get; private set; }

        // Private data
        List<int> ratings;

        // Constructors
        public Movie(string theTitle, string theDirector, int theYear) {
            Title = theTitle;
            Director = theDirector;
            Year = theYear;
            ratings = new List<int>();
        }

        // Methods
        public void RateMovie(int theRating) {
            if (theRating >= minRating && theRating <= maxRating) {
                ratings.Add(theRating);
            } else {
                throw new Exception("Invalid rating entered");
            }
        }
        // Calculate average movie rating
         public double GetAverageRating() {
            double sum = 0;
            for (int i = 0; i < ratings.Count; i++) {
                sum += ratings[i];
            }

            double averageRating = sum / ratings.Count;
            double roundedRating = Math.Round(averageRating, 2);
            return roundedRating;
        }
        // Print all movie detials
        public void PrintDetails() {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Year: {Year}\n");
        }

    }
}

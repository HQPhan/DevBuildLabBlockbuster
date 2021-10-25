using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class BlockBuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public BlockBuster()
        {
            Movies.Add(new Movie("The Scorcher","Action",115)); //dvd
            Movies.Add(new Movie("Alien: Re-resurrection", "Horror", 180)); //dvd
            Movies.Add(new Movie("Alladin's Evil Twin", "Drama", 72)); //dvd
            Movies.Add(new Movie("The Olsen Twins: Senior Edition", "Comedy", 118)); //vhs
            Movies.Add(new Movie("Judge Dredd's Retirement", "Action", 220)); //vhs
            Movies.Add(new Movie("Sumthin's Up With Mary", "Romance", 666)); //vhs
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i}) {Movies[i]}");
            }            
        }

        public void CheckOut()
        {             
            bool userContinue = true;
            while (userContinue)
            {
                PrintMovies();
                int userIndex = int.Parse(UserInput("Please Select a Movie from the list: "));
                for (int i = 0; i < Movies.Count; i++)
                {
                    Movie mv = Movies[i];
                    if (i == userIndex)
                    {
                        Console.WriteLine(mv);
                    }
                    else
                    {
                        continue;
                    }
                }

                string watch = UserInput("Do you want to watch the movie? (y/n)");
                if (watch == "y")
                {
                    //foreach (string m in Movies)
                    //{
                    //    DVD dvd = new DVD(m[0],m[1],m[2]);
                    //}

                    
                    //How do I pull Play() methods in from subclass DVD and VHS?
                    //Play the scenes
                }
                else
                {
                   //Ask user if they want to cotinue ->
                   //else block is empty so nothing is to do here (do we even need an else block?)
                }
                
                userContinue = KeepGoing();
            }
        }

        public string UserInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public bool KeepGoing()
        {
            string again = UserInput("Would you like to watch another movie? (y/n): ");
            if (again == "y")
            {
                return true;
            }
            else if (again == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Not valid. Try again!");
                return KeepGoing();
            }
        }
    }
}

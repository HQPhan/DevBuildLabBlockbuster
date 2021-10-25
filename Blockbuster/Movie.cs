using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get ; set; }
        public int RunTime { get; set; }

        //I'm not sure where and how I should place the list of string Scenes.
        //There are 30 scenes total for 6 movies, 5 scenes each.
        //Code a list within a list?
        //Does the list need to need to be in a 'public' block?
        List<string> Scenes = new List<string>() { "Scorcher finds baby named Bob", "Bob trains to become assasin", "Bob sides with evil", "Scorcher rescues Bob", "Scorcher and Bob saves the world" };

        public Movie(string Title, string Category, int RunTime)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
        }

        public override string ToString()
        {
            string output = $"Title: {Title}\n";
            output += $"Category: {Category}\n";
            output += $"Runtime: {RunTime}\n";
            return output;
        }

        public virtual void PrintScenes()
        {            
            for (int i = 0; i < Scenes.Count ; i++)
            {
                Console.WriteLine($"Scene {i+1}: {Scenes[i]}");
            }           
        }

        public virtual void Play()
        {
            Console.WriteLine();
            //Not sure what goes in here.
            //Can it be empty since Play() from subclass DVD and VHS are overriding it?
        }
    
    }
}

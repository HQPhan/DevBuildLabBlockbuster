using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class DVD : Movie
    {
        List<string> scenesTS = new List<string>()
            { "Scorcher finds baby named Bob","Bob trains to become assasin","Bob sides with evil","Scorcher rescues Bob","Scorcher and Bob saves the world" };
        List<string> scenesAR = new List<string>()
            { "Alien eats rat","Alien gets captured","Alien eggs multiply by the millions","Alien takes over Earth","Virus released to destroy aliens"};
        List<string> scenesAET = new List<string>()
            { "Aladin learns he has twin, Baladin","Baladin takes over Aladin's kingdom","Jasmine gets captured","Aladin saves Jasmine","Abubu dies figthing evil carpet"};
        public DVD(string Title, string Category, int RunTime) : base(Title, Category, RunTime)
        {
            Play();
            
        }

        public override void Play()
        {
            for (int i = 0; i < scenesTS.Count; i++)
            {                
                Console.WriteLine($"What scene of the DVD {Title} would you like to watch? (0-4)"); ;                
            }

        }
    }
}

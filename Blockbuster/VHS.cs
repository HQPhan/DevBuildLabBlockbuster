using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        List<string> scenesTOT = new List<string>()
            { "Olsen Twins in senior home","Grandkids takes Olsen twins to camp","Olsen twins get separated","Bulding the Olsen pontoon","Olsen twins return to senior home"};
        List<string> scenesJD = new List<string>()
            { "J. Dredd talks about retirement","J. Dredd accepts mission to kill Bill","Helicopters crash on skyscrapers","J. Dredd finds new weapons","J. Dredd discovers Lady J. Dredd"};
        List<string> scenesSUWM = new List<string>()
            { "Ben Stiller hitting on girls at beach","Ben meets another Mary","Old Mary finds out about New Mary","Cats fight in the alley","Both Mary's leave Ben"};
        public VHS(int CurrentTime, string Title, string Category, int RunTime) : base(Title, Category, RunTime)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            Console.Write("Which scene would you like to watch? (1-5)");
            int userPickScene = int.Parse(Console.ReadLine());

            for (int i = userPickScene; i < 5; i++)
            {
                PrintScenes();
                CurrentTime++;
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}

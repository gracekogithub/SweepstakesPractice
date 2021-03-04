using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes 
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        
        public string Name { get; set; }
        public Dictionary<int, Contestant> Contestant { get; set; }
      
      
        public Sweepstakes(string name)
        {
            Name = name;
            
        }
        public void RegisterContestant(Contestant contestants)
        {
            Dictionary<int, Contestant> names = new Dictionary<int, Contestant>();
            foreach (var contestant in names)
            {
                contestants.Display();
            }
        }
        public Contestant PickWinner()
        {
            Console.WriteLine("The winner is: ");
        }
        public void PrintContestantinfo(Contestant contestant)
        {

        }
    }
}

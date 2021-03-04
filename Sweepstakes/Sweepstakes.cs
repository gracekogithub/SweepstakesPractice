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
            
        public Sweepstakes(string name)
        {
            Name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {

        }
        public Contestant PickWinner()
        {

        }
        public void PrintContestantinfo(Contestant contestant)
        {

        }
    }
}

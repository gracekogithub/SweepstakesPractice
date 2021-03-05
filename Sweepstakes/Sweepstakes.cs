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
        public Dictionary<int, Contestant> Contestant
        {
            get { return contestants; }
            protected set { contestants = value; }
        }
        public Sweepstakes(string name)
        { 
            Name = name;
        }
        public void RegisterContestant(Contestant contestants)
        {
            Dictionary<int, Contestant> lookup = new Dictionary<int, Contestant>();
            int i =0;
            foreach (var data in lookup)
            {
                contestants.Display();
                lookup.Add(contestants.RegistrationNumber, contestants);
            }
            Console.WriteLine(lookup[i].Display());

        }

        public Contestant PickWinner(Contestant contestants)
        {
            int randomRegistrationNumber;
            Random actualWinner = new Random();
            randomRegistrationNumber = actualWinner.Next();
            Console.WriteLine("The winner is: "+ randomRegistrationNumber);

            return contestants;
            
        }
        public void PrintContestantinfo(Contestant contestant)
        {
            Console.WriteLine(contestant.Display());
        }
    }
}

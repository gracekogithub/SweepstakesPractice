using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface  
    {
        public static string GetUserInputFor(string prompt)
        {
            Contestant contestant = new Contestant();
            Console.WriteLine("please, register your sweepstake");
            contestant.Display();
            return prompt;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;   
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
            Console.WriteLine(stack.Peek());
            
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes getSweep = stack.Pop();
            Console.WriteLine(stack.Peek());
            return getSweep;
        }
    }
}

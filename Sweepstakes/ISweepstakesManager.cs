using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}
//types of dependency injection: constructor injection, setter injection, interface injection
//benefit of using dependency injection:
//:increase code reusabiliy, readability, maintainability, testibility and cohesion
//:reduces coupling
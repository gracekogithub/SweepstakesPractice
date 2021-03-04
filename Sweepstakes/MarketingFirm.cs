using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }
        public void ManagerChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    _manager = new SweepstakesStackManager();
                    break;
                case "2":
                    _manager = new SweepstakesQueueManager();
                    break;
                default:
                    throw new ApplicationException(string.Format("Invalid"));
            }
        }
        
        public void CreateSweepstake()
        {

        }
    }
}

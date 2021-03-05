using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string EmailAddress { get; protected set; }
        public int RegistrationNumber { get; protected set; }
        //public Contestant(string firstname, string lastName, string emailAddress, int registrationNumber)
        //{
        //    FirstName = firstname;
        //    LastName = lastName;
        //    EmailAddress = emailAddress;
        //    RegistrationNumber = registrationNumber;

        //}
        public string Display()
        {
            return String.Format("{0}: {1}, {2}, {3}", RegistrationNumber, LastName, FirstName, EmailAddress);
        }


    }
}

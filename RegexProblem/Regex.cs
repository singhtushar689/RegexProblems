using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class RegexProblem
    {
        public void ValidateFirstName(string name)
        {
            //Tushar
            string firstName = "^[A-Z]{1}[a-z]{3,}?";
            if(Regex.IsMatch(name,firstName))
            {
                Console.WriteLine( "First name is matching with Regex");
            }
            else
            {
                Console.WriteLine("FirstName is not matching with Regex");
            }
        }
        public void ValidateLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name is matching with Regex");
            }
            else
            {
                Console.WriteLine("Last Name is not matching with Regex");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexProblem regex = new RegexProblem();
            regex.ValidateFirstName("Tushar");
            regex.ValidateLastName("Singh");
            regex.ValidateEmail("abc.xyz@bl.co.in");
            regex.ValidatePhoneNumber("91 9896271453");
            regex.ValidatePassword("Password");
            regex.ValidateStringPassword("Tushar123");
            regex.ValidateNumericPassword("Tushar689");
            regex.ValidateSpecialCharacter("Tushar")
            Console.ReadLine();
        }
    }
}

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
            regex.ValidateLastName("Vikas");
            regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            regex.ValidatePhoneNumber("91 0143433425");
            regex.ValidatePassword("Tushar123");
            regex.ValidateString("Tushareret");
            regex.ValidateNumericPassword("Tushar1");
            regex.ValidateSpecialCharacter("Tushar@123");
            Console.ReadLine();
        }
    }
}

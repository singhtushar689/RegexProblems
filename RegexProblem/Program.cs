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
            Console.ReadLine();
        }
    }
}

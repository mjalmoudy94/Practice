using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    class App
    {
        static void Main(string[] args)
        {
            string userInput = "01234567890";

            var ReplacerResult = AdvanceReplacer.ReplaceZeroWithStar(userInput, ReplaceingMethod.UsingArray);
            if (ReplacerResult.isSuccess)
            {
                Console.WriteLine(userInput + " -> " + ReplacerResult.result);
            }
            else
            {
                Console.WriteLine("Only Numbers Are Alowed");
            }
        }
    }
}

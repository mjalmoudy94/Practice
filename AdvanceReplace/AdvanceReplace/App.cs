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

            AdvanceZeroWithStarReplacer dictionaryMethodReplacer = new AdvanceZeroWithStarReplacer(new DictionaryMethodZeroWithStarReplacer());

            var ReplacerResult = dictionaryMethodReplacer.ReplaceZeroWithStar(userInput);
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

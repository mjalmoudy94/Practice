using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    class App
    {
        // از شرط فقط جهت نمایش  نتیجه استفاده شده
        // ولیدیشن و جایگذاری بدون شرط پیاده سازی شدن
        static void Main(string[] args)
        {
            string wrong_UserInput = "l4580G054Y";
            string right_UserInput = "1458020547";


            // Use Array To Replace And Validate
            // Wrong User Input
            var wrong_ReplacerResult_UsingArray = AdvanceReplacer.ReplaceZero_WithStar_UsingArray(wrong_UserInput);
            if (wrong_ReplacerResult_UsingArray.isSuccess)
            {
                Console.WriteLine(wrong_ReplacerResult_UsingArray.result);
            }
            else
            {
                Console.WriteLine("Only Numbers Are Alowed");
            }

            // Right User Input
            var right_ReplacerResult_UsingArray = AdvanceReplacer.ReplaceZero_WithStar_UsingArray(right_UserInput);
            if (right_ReplacerResult_UsingArray.isSuccess)
            {
                Console.WriteLine(right_ReplacerResult_UsingArray.result);
            }
            else
            {
                Console.WriteLine("Only Numbers Are Alowed");
            }


            // Use Dictionary To Replace And Validate
            // Wrong User Input
            var wrong_ReplacerResult_UsingDictionary = AdvanceReplacer.ReplaceZero_WithStar_UsingDictionary(wrong_UserInput);
            if (wrong_ReplacerResult_UsingDictionary.isSuccess)
            {
                Console.WriteLine(wrong_ReplacerResult_UsingDictionary.result);
            }
            else
            {
                Console.WriteLine("Only Numbers Are Alowed");
            }

            // Right User Input
            var right_ReplacerResult_UsingDictionary = AdvanceReplacer.ReplaceZero_WithStar_UsingDictionary(right_UserInput);
            if (right_ReplacerResult_UsingDictionary.isSuccess)
            {
                Console.WriteLine(right_ReplacerResult_UsingDictionary.result);
            }
            else
            {
                Console.WriteLine("Only Numbers Are Alowed");
            }


            // END
        }
    }
}

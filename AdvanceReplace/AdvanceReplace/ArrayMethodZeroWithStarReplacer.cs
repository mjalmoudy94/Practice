using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public class ArrayMethodZeroWithStarReplacer : IZeroWithStarReplacer
    {
        readonly char[] safeCharNumbersArray;

        public ArrayMethodZeroWithStarReplacer()
        {
            safeCharNumbersArray = new char[10] { '*', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        public (bool isSuccess, string result) Replace(string input)
        {
            bool validatingResult = true;
            string replacingResult = string.Empty;

            try
            {
                foreach (char character in input.ToArray())
                {
                    int characterAsIndex = int.Parse(character.ToString());
                    replacingResult += safeCharNumbersArray[characterAsIndex];
                }
            }
            catch (Exception)
            {
                validatingResult = false;
                replacingResult = null;
            }

            return (validatingResult, replacingResult);
        }
    }
}

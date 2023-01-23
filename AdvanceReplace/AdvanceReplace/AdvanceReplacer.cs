using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public static class AdvanceReplacer
    {
        static readonly char[] safeCharNumbersArray;
        static readonly Dictionary<char, char> safeCharNumbersDictionary;

        static AdvanceReplacer()
        {
            safeCharNumbersArray = new char[10] { '*', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            safeCharNumbersDictionary = new Dictionary<char, char>()
            {
                {'0', '*' },
                {'1', '1' },
                {'2', '2' },
                {'3', '3' },
                {'4', '4' },
                {'5', '5' },
                {'6', '6' },
                {'7', '7' },
                {'8', '8' },
                {'9', '9' },
            };
        }

        public static (bool isSuccess, string result) ReplaceZeroWithStar(string input, ReplaceingMethod replaceingMethod)
        {
            bool validatingResult = true;
            string replacingResult = string.Empty;

            try
            {
                switch (replaceingMethod)
                {
                    case ReplaceingMethod.UsingArray:
                        foreach (char character in input.ToArray())
                        {
                            int characterAsIndex = int.Parse(character.ToString());
                            replacingResult += safeCharNumbersArray[characterAsIndex];
                        }
                        break;

                    case ReplaceingMethod.UsingDictionary:
                        List<char> reslitList = input.ToList().Select(x => safeCharNumbersDictionary[x]).ToList();
                        replacingResult = string.Join("", reslitList);
                        break;
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

    public enum ReplaceingMethod
    {
        UsingArray,
        UsingDictionary,
    }
}

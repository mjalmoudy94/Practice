using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public static class AdvanceReplacer
    {
        static readonly char[] charBoxArray;
        static readonly Dictionary<char, char> charBoxDictionary;

        static AdvanceReplacer()
        {
            charBoxArray = new char[10] { '*', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            charBoxDictionary = new Dictionary<char, char>();
            charBoxDictionary.Add('0', '*');
            charBoxDictionary.Add('1', '1');
            charBoxDictionary.Add('2', '2');
            charBoxDictionary.Add('3', '3');
            charBoxDictionary.Add('4', '4');
            charBoxDictionary.Add('5', '5');
            charBoxDictionary.Add('6', '6');
            charBoxDictionary.Add('7', '7');
            charBoxDictionary.Add('8', '8');
            charBoxDictionary.Add('9', '9');
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
                            replacingResult += charBoxArray[characterAsIndex];
                        }
                        break;

                    case ReplaceingMethod.UsingDictionary:
                        List<char> reslitList = input.ToList().Select(x => charBoxDictionary[x]).ToList();
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

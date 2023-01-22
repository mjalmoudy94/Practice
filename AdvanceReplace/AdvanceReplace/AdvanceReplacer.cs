using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public static class AdvanceReplacer
    {
        public static (bool isSuccess, string result) ReplaceZero_WithStar_UsingArray(string input)
        {
            char[] charBox = new char[10] { '*', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool validation = true;
            string result = "";

            try
            {
                foreach (char character in input.ToArray())
                {
                    result += charBox[int.Parse(character.ToString())];
                }
            }
            catch (Exception)
            {
                validation = false;
                result = null;
            }

            return (validation, result);
        }

        public static (bool isSuccess, string result) ReplaceZero_WithStar_UsingDictionary(string input)
        {
            Dictionary<char, char> charBox = new Dictionary<char, char>();
            charBox.Add('0', '*');
            charBox.Add('1', '1');
            charBox.Add('2', '2');
            charBox.Add('3', '3');
            charBox.Add('4', '4');
            charBox.Add('5', '5');
            charBox.Add('6', '6');
            charBox.Add('7', '7');
            charBox.Add('8', '8');
            charBox.Add('9', '9');

            bool validation = true;
            string result = string.Empty;

            try
            {
                List<char> reslitList = input.ToList().Select(x => charBox[x]).ToList();
                result = string.Join("", reslitList);
            }
            catch (Exception)
            {
                validation = false;
            }

            return (validation, result);
        }
    }
}

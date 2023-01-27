using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public class DictionaryMethodZeroWithStarReplacer : IZeroWithStarReplacer
    {
        readonly Dictionary<char, char> safeCharNumbersDictionary;

        public DictionaryMethodZeroWithStarReplacer()
        {
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

        public (bool isSuccess, string result) Replace(string input)
        {
            bool validatingResult = true;
            string replacingResult = string.Empty;

            try
            {
                List<char> reslitList = input.ToList().Select(x => safeCharNumbersDictionary[x]).ToList();
                replacingResult = string.Join("", reslitList);
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

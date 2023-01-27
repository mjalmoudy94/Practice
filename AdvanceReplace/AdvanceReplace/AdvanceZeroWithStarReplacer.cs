using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public class AdvanceZeroWithStarReplacer
    {
        IZeroWithStarReplacer replacer;

        public AdvanceZeroWithStarReplacer(IZeroWithStarReplacer replacer)
        {
            this.replacer = replacer;
        }

        public (bool isSuccess, string result) ReplaceZeroWithStar(string input)
        {
            return replacer.Replace(input);
        }
    }
}

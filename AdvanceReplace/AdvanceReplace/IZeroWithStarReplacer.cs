using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalmoudy.String
{
    public interface IZeroWithStarReplacer
    {
        (bool isSuccess, string result) Replace(string input);
    }
}

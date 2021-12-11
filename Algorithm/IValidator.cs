using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Lab.Algorithm
{
    internal interface IValidator
    {
        string Validate(string str);

        /*bool IsValid(string str);

        int[] GetIndexes(string str);

        string GetFormattedString();
        */
    }
}

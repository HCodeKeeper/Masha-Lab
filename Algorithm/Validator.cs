using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Lab.Algorithm
{
    internal class Validator : IValidator
    {
        public string Validate(string str)
        {
            if (str == null)
            {
                throw new NullReferenceException("string is not specified");
            }
            if (str.Length > 255)
            {
                throw new ArgumentException("string chars > 255");
            }

            char stopChar = '0';
            StringBuilder sb = new StringBuilder(str);
            for( int i=0; i < sb.ToString().Length; i++ )
            {
                char c = sb[i];

                if (new char[] { '!', '.', '?' }.Contains(c))
                {
                    stopChar = c;
                    continue;
                }
                if(Char.IsLower(c) && stopChar != '0')
                {
                    sb[i] = Char.ToUpper(sb[i]);
                    stopChar = '0';
                }
                stopChar = '0';
            }
            return sb.ToString();
        }
    }
}

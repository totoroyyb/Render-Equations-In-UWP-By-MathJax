using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenderMathUWP.Helper
{
    public class LatexStringFormer
    {
        public static string AddBackSlash(string str)
        {            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\\')
                {
                    str.Insert(i + 1, "\\");
                    i++;
                }
            }

            return str;
        }
    }
}

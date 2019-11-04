using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Upper
    {
        protected static string NameToUpper(string name)
        {
            List<string> split = new List<string>() { };

            char first;
            string upper;
            string lower;
            string result = "";
            string nameCaps = "";

            if (name.Contains(" ") || name.Contains('-'))
            {
                string[] stringSplit = null;

                if (name.Contains(" "))
                {
                    stringSplit = name.Split(' ');
                }
                else if (name.Contains('-'))
                {
                    stringSplit = name.Split('-');
                }

                foreach (string x in stringSplit)
                {
                    first = x[0];
                    lower = first.ToString();
                    upper = first.ToString().ToUpper();
                    nameCaps = upper + x.Remove(0, 1);
                    split.Add(nameCaps);
                }

                result = string.Join(" ", split.ToArray());
            }
            else
            {
                first = name[0];
                lower = first.ToString();
                upper = first.ToString().ToUpper();
                result = upper + name.Remove(0, 1);
            }

            return result;
        }
    }
}

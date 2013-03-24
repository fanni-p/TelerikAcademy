using System;
using System.Text;

namespace _1.Extension_method_Substring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < (index + length); i++)
            {
                result.Append(str[i]);
            }
            return result;
        }
    }
}

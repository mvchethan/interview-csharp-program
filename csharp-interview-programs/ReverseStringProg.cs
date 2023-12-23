using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class ReverseStringProg
    {
        public void ReverseString_Method1_Approch1(string str)
        {
            Console.WriteLine("String Append Approch");
            string reverse = string.Empty;
            for (int i = str.Length-1; i>=0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
        }

        public void ReverseString_Method1_Approch2(string str)
        {
            Console.WriteLine("For Loop Approch");
            char[] str_char = str.ToCharArray();
            for (int i=0,j = str.Length -1; i<j;i++,j--)
            {
                str_char[i] = str[j];
                str_char[j] = str[i];
            }
            string res = new string(str_char);
            Console.WriteLine(res);
        }


    }
}

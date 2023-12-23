using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class CharactersProg
    {
        public void CharacterCount_Method1(string str)
        {
            Console.WriteLine("Dictionary Approch");
            str = str.ToLower();
            Dictionary<char, int> char_count = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (ch != ' ')
                {
                    if (char_count.ContainsKey(ch))
                    {
                        char_count[ch]++;
                    }
                    else
                    {
                        char_count.Add(ch, 1);
                    }
                }
            }

            foreach (var chr in char_count)
            {
                Console.WriteLine("{0} : {1}", chr.Key, chr.Value);
            }
        }

        public void CharacterCount_Method2(string str)
        {
            Console.WriteLine("Linq Approch");
            str = str.ToLower();
            var char_count = str.GroupBy(x => x).Select(x => new {
                Key = x.Key,
                Value = x.Count()
            });

            foreach (var chr in char_count)
            {
                Console.WriteLine("{0} : {1}", chr.Key, chr.Value);
            }
        }
    }
}

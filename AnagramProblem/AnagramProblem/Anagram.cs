using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramProblem
{
    public class Anagram
    {
        public bool IsAnagram(string first, string  second)
        {
            first = first.ToLower();
            second = second.ToLower();
            if(first.Length != second.Length)
            {
                Console.WriteLine("Please enter two string as same length.");
                return false;
            }
            else
            {
                char[] firstArray = first.ToCharArray();
                char[] secondArray = second.ToCharArray();
                Array.Sort(firstArray);
                Array.Sort(secondArray);
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if(firstArray[i] != secondArray[i])
                    {
                        return false;
                    }
                    
                }
                return true;
            }
        }
    }
}

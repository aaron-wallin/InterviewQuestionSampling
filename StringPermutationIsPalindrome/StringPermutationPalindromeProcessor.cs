using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutationIsPalindrome
{
    public class StringPermutationPalindromeProcessor
    {
        private string _stringToProcess;
        public StringPermutationPalindromeProcessor(string stringToProcess)
        {
            _stringToProcess = stringToProcess;
        }

        public bool Process()
        {
            if (CheckForPalindrome(_stringToProcess))
            {
                Console.WriteLine(_stringToProcess);
                return true;
            }
            return GetPermutation(_stringToProcess.ToCharArray(), 0, _stringToProcess.Length - 1);
        }

        private bool GetPermutation(char[] characters, int start, int end)
        {
            if (start == end)
            {
                //_output.Add(new string(characters));
                if(CheckForPalindrome(new string(characters)))
                {
                    Console.WriteLine(new string(characters));
                    return true;
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(ref characters[start], ref characters[i]);
                    if(GetPermutation(characters, start + 1, end)) return true;
                    Swap(ref characters[start], ref characters[i]);
                }
            }

            return false;
        }

        private void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        private bool CheckForPalindrome(string stringToProcess)
        {
            var charArray = stringToProcess.ToCharArray();
            var lengthIndex = charArray.Length - 1;

            for (int i = 0; i <= (lengthIndex / 2); i++)
            {
                if (i > lengthIndex - i)
                    break;

                if (charArray[i] != charArray[lengthIndex - i])
                    return false;
            }

            return true;
        }
    }
}

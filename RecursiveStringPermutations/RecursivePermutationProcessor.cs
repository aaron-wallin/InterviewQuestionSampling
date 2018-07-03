using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStringPermutations
{
    public class RecursivePermutationProcessor
    {
        private static List<string> _output = new List<string>();
        private string _stringToProcess;

        public RecursivePermutationProcessor(string stringToProcess)
        {
            _stringToProcess = stringToProcess;
        }

        public List<string> Process()
        {            
            GetPermutation(_stringToProcess.ToCharArray(), 0, _stringToProcess.Length - 1);
            return _output;
        }

        private void GetPermutation(char[] characters, int start, int end)
        {
            if (start == end)
            {                
                _output.Add(new string(characters));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(ref characters[start], ref characters[i]);                    
                    GetPermutation(characters, start + 1, end);
                    Swap(ref characters[start], ref characters[i]);
                }
            }
        }

        private void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }
    }
}

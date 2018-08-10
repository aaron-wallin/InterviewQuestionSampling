using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStringPermutations
{
    public class RecursivePermutationStringProcessor3
    {
        private readonly string _stringToProcess;

        public RecursivePermutationStringProcessor3(string stringToProcess)
        {
            _stringToProcess = stringToProcess;
        }

        public ISet<string> Process()
        {
            var set = new HashSet<string>();
            GetPermutations(_stringToProcess, set);
            return set;
        }

        public void GetPermutations(string stringToProcess, ISet<string> set)
        {
            for (int i = 0; i < stringToProcess.Length; i++)
            {
                var processingCharacter = stringToProcess[i];
                var newString = stringToProcess.Remove(i, 1);

                GetPermutations(newString, set);

                

                CreatePermutations(processingCharacter, newString, set);
            }            
        }

        private void CreatePermutations(char processingCharacter, string partialString, ISet<string> set)
        {
            for (int j = 0; j <= partialString.Length; j++)
            {
                var permutation = partialString.Substring(0, j) + processingCharacter + partialString.Substring(j);
                set.Add(permutation);
            }
        }
    }
}

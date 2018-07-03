using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPalindrome
{
    public class BasicPalindromeProcessor
    {
        private string _stringToProcess;
        public BasicPalindromeProcessor(string stringToProcess)
        {
            _stringToProcess = stringToProcess.Replace(" ","");
        }

        public bool Process()
        {
            var charArray = _stringToProcess.ToCharArray();
            var lengthIndex = charArray.Length - 1;

            for(int i = 0; i <= (lengthIndex / 2); i++)
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

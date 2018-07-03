using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis
{
    public class MatchingParenthesisProcessor
    {
        private readonly string _stringToProcess;
        private readonly int _firstParenPosition;

        public MatchingParenthesisProcessor(string stringToProcess, int firstParenPosition)
        {
            _stringToProcess = stringToProcess;
            _firstParenPosition = firstParenPosition;
        }

        public int FindMatch()
        {
            var parenthesisPositionQueue = new Stack<int>();
            var chars = _stringToProcess.ToCharArray();

            if (_firstParenPosition > chars.Length - 1)
                throw new Exception("Invalid starting position");

            var firstParen = chars[_firstParenPosition];

            if (firstParen != '(')
                throw new Exception("First character is not an open parenthesis");

            for(int i = _firstParenPosition; i < chars.Length - 1; i++)
            {
                switch (chars[i])
                {
                    case '(':
                        parenthesisPositionQueue.Push(i);
                        break;
                    case ')':
                        parenthesisPositionQueue.Pop();
                        break;
                    default:
                        continue;
                }
                
                if (parenthesisPositionQueue.Count == 0)
                    return i;
            }

            return -1;
        }
    }
}

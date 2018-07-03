using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceIsRight
{
    public class PriceIsRightProcessor
    {
        private int _price;
        private int[] _guesses;

        public PriceIsRightProcessor(int price, int[] guesses)
        {
            _price = price;
            _guesses = guesses;
        }

        public int FindWinner()
        {
            var sl = new SortedDictionary<int, int>();

            for (int i = 0; i < _guesses.Length; i++)
            {
                if (_guesses[i] > _price) continue;
                sl.Add(_guesses[i] - _price, i);
            }

            return sl.Count() == 0 ? -1 : sl.LastOrDefault().Value;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPrices
{
    public class StockPriceProcessor
    {
        private readonly int[] _stockPrices;

        public StockPriceProcessor(int[] stockPrices)
        {
            _stockPrices = stockPrices;
        }

        public int Process()
        {
            if (_stockPrices.Length < 2) return 0;

            int minPrice = _stockPrices[0];
            int maxProfit = _stockPrices[1] - _stockPrices[0];

            for (int i = 1; i < _stockPrices.Length; i++)
            {
                var currentPrice = _stockPrices[i];
                var potentialProfit = currentPrice - minPrice;

                maxProfit = Math.Max(maxProfit, potentialProfit);
                minPrice = Math.Min(minPrice, currentPrice);
            }

            return maxProfit;
        }
    }
}

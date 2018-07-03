using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainWater
{
    public class RainWaterProcessor
    {
        private readonly int[] _elevations;

        public RainWaterProcessor(int[] elevations)
        {
            _elevations = elevations;
        }

        public int Process()
        {
            int[] leftToRightScan = new int[_elevations.Length];
            int[] rightToLeftScan = new int[_elevations.Length];

            leftToRightScan[0] = _elevations[0];
            int maxHeight = _elevations[0];
            for (int i = 1; i < _elevations.Length; i++)
            {
                if (_elevations[i] < maxHeight)
                {
                    leftToRightScan[i] = maxHeight;
                }
                else
                {
                    leftToRightScan[i] = _elevations[i];
                    maxHeight = _elevations[i];
                }
            }

            rightToLeftScan[_elevations.Length - 1] = _elevations[_elevations.Length - 1];
            maxHeight = _elevations[_elevations.Length - 1];
            for (int i = _elevations.Length - 2; i >= 0; i--)
            {
                if (_elevations[i] < maxHeight)
                {
                    rightToLeftScan[i] = maxHeight;
                }
                else
                {
                    rightToLeftScan[i] = _elevations[i];
                    maxHeight = _elevations[i];
                }
            }

            int result = 0;
            for (int i = 0; i < _elevations.Length; i++)
            {
                result += Math.Min(rightToLeftScan[i], leftToRightScan[i]) - _elevations[i];
            }

            return result;
        }
    }
}

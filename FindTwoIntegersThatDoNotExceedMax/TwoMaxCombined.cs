using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTwoIntegersThatDoNotExceedMax
{
    public class TwoMaxCombined
    {
        private readonly int _flightLength;
        private readonly int[] _listOfMovieLengths;

        public TwoMaxCombined(int flightLength, int[] listOfMovieLengths)
        {
            this._flightLength = flightLength;
            this._listOfMovieLengths = listOfMovieLengths;
        }

        public bool DetermineMatch()
        {
            bool result = false;
            var set = new HashSet<int>();            

            for(int i = 0; i < _listOfMovieLengths.Length; i++)
            {
                int firstMovieLength = _listOfMovieLengths[i];
                int secondTargetMovieLength = _flightLength - firstMovieLength;
                
                if (set.Contains(secondTargetMovieLength))
                {
                    return true;
                }

                set.Add(firstMovieLength);
            }

            return result;
        }
    }
}

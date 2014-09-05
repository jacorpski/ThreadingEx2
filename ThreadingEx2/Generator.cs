using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingEx2
{
    /// <summary>
    /// This class will be responsible for generating or loading 
    /// a large set of data to be used in this threading exercise.
    /// </summary>
    class Generator
    {
        private int[][] _result;
        
        private const int MAXVALUE = 100000;
        private Random rnd = new Random();

        public Generator()
        {
            
        }

        public int[][] Result
        {
            get { return _result; }
        }

        public void Generate(int howManyArrays, int howManyInEachArray)
        {
            _result = new int[howManyArrays][];
            for (int i = 0; i < howManyArrays; i++)
            {
                _result[i] = new int[howManyInEachArray];
                for (int j = 0; j < howManyInEachArray; j++)
                {
                    _result[i][j] = rnd.Next(MAXVALUE * 2) - MAXVALUE;
                }
            }
        }
    }
}

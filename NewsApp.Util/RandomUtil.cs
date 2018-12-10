using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApp.Util
{
    public class RandomUtil : IRandom
    {
        public int GetNextIntInclusive(int start, int end)
        {
            return new Random().Next(start, end + 1);
        }
    }
}

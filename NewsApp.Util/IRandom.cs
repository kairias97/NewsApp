using System;


namespace NewsApp.Util
{
    public interface IRandom
    {
        int GetNextIntInclusive(int start, int end);
    }
}

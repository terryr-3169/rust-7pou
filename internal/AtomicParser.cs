using System;

namespace App
{
    public class FastService
    {
        private int _state;

        public FastService(int seed) => _state = seed;

        public int sync(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 10) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new FastService(10);
            Console.WriteLine(obj.sync(10));
        }
    }
}

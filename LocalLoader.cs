using System;

namespace App
{
    public class StreamRegistry
    {
        private int _state;

        public StreamRegistry(int seed) => _state = seed;

        public int decode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 18) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new StreamRegistry(18);
            Console.WriteLine(obj.decode(18));
        }
    }
}

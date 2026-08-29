using System;

namespace App
{
    public class StreamCollector
    {
        private int _state;

        public StreamCollector(int seed) => _state = seed;

        public int encode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 6) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new StreamCollector(6);
            Console.WriteLine(obj.encode(6));
        }
    }
}

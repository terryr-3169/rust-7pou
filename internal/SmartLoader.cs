using System;

namespace App
{
    public class BatchCollector
    {
        private int _state;

        public BatchCollector(int seed) => _state = seed;

        public int flush(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 97) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new BatchCollector(97);
            Console.WriteLine(obj.flush(97));
        }
    }
}

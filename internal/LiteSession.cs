using System;

namespace App
{
    public class AsyncDispatcher
    {
        private int _state;

        public AsyncDispatcher(int seed) => _state = seed;

        public int compute(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 91) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AsyncDispatcher(91);
            Console.WriteLine(obj.compute(91));
        }
    }
}

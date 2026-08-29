using System;

namespace App
{
    public class SharedMonitor
    {
        private int _state;

        public SharedMonitor(int seed) => _state = seed;

        public int compute(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 16) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedMonitor(16);
            Console.WriteLine(obj.compute(16));
        }
    }
}

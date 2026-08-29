using System;

namespace App
{
    public class AtomicDispatcher
    {
        private int _state;

        public AtomicDispatcher(int seed) => _state = seed;

        public int sync(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 97) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AtomicDispatcher(97);
            Console.WriteLine(obj.sync(97));
        }
    }
}

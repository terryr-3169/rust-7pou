using System;

namespace App
{
    public class FastEngine
    {
        private int _state;

        public FastEngine(int seed) => _state = seed;

        public int build(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 9) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new FastEngine(9);
            Console.WriteLine(obj.build(9));
        }
    }
}

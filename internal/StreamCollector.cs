using System;

namespace App
{
    public class SecureService
    {
        private int _state;

        public SecureService(int seed) => _state = seed;

        public int compute(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 22) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SecureService(22);
            Console.WriteLine(obj.compute(22));
        }
    }
}

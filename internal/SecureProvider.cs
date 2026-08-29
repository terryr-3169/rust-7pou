using System;

namespace App
{
    public class SecureService
    {
        private int _state;

        public SecureService(int seed) => _state = seed;

        public int collect(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 63) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SecureService(63);
            Console.WriteLine(obj.collect(63));
        }
    }
}

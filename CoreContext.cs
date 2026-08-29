using System;

namespace App
{
    public class StreamService
    {
        private int _state;

        public StreamService(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 81) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new StreamService(81);
            Console.WriteLine(obj.handle(81));
        }
    }
}

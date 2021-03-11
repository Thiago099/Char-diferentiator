using System;

namespace McGyver
{
    class Program
    {
        char[,] data = { { 'A', 'C' }, { 'D', 'F' }, { 'G', 'K' },{ 'a','c'},{'d','f'},{'g','i' } };

        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            /*for (char i = 'A'; i <= 'Z' ; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();*/
            solve();
        }
        void solve()
        {
            solve(0, data.GetLength(0)) ;
        }
        void solve(int right,int left)
        {
            int middle = (right + left) / 2;
            if (left - right <= 1)
            {
                Console.WriteLine($"return '{data[middle, 0]}';");
                return;
            }
            Console.WriteLine($"if(m < '{data[middle, 0]}')");
            solve(right, middle);
            Console.WriteLine("else");
            solve(middle, left);
        }
    }

}   

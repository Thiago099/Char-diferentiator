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
            solve(0, data.GetLength(0),true) ;
        }
        void solve(int right,int left,bool line)
        {
            int middle = (right + left) / 2;
            if (left - right <= 1)
            {
                if (!line) Console.Write("           ");
                Console.Write($" return '{data[middle, 0]}';\n");
                return;
            }
            else if(line)Console.Write("\n     ");
            Console.Write($"if(m < '{data[middle, 0]}')");
            solve(right, middle,true);
            Console.Write("else ");
            solve(middle, left,false);
        }
        /*
         * implementation of the functional algorithim without identation
        void solve(int right, int left)
        {
            int middle = (right + left) / 2;
            if (left - right <= 1)
            {
                Console.WriteLine($"return '{data[middle, 0]}';");
                return;
            }
            Console.WriteLine($"if(m < '{data[middle, 0]}')");
            solve_basic(right, middle);
            Console.WriteLine("else");
            solve_basic(middle, left);
        }*/
    }

}   

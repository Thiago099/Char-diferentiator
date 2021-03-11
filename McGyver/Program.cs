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
            for (char i = 'A'; i <= 'Z' ; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            solve();
        }
        void solve()
        {
            solve(0, data.GetLength(0)) ;
        }
        void solve(int esquerda,int direita)
        {
            int meio = (esquerda + direita) / 2;
            if (direita-esquerda<=1)
            {
                Console.WriteLine($"return '{data[meio,0]}';");
                return;
            }
            Console.WriteLine($"if(m < '{data[meio,0]}')");
            solve(esquerda,meio);
            Console.WriteLine("else");
            solve(meio, direita);
        }
    }

}   

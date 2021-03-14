using System;
using System.Text;
using System.Collections.Generic;

namespace McGyver
{
    class Program
    {
        List<Element> data=new List<Element>();

        
        public Program()
        {
            string display = generate();
            while(true)
            {

                if(data.Count>0)
                {
                    int j = 0;
                    bool toggle = false;

                    for (int i = 0; i < display.Length; i++)
                    {
                        if (display[i] == data[j].a)
                        {
                            if (toggle)
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            else
                                Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write(display[i]);
                        if (display[i] == data[j].b)
                        {
                            if (j < data.Count-1)
                            {
                                j++;
                                toggle = !toggle;
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                else
                    Console.WriteLine(display);
                
                if(data.Count!=0)
                solve();
                string cmd = Console.ReadLine();
                string[] input = cmd.Split(' ');
                char a;
                char b;
                char r;
                if(input.Length>=2)
                {
                    r = input[0][0];
                    if (input[1].Length==1)
                    {
                        a = input[1][0];
                        b = a;
                    }
                    else
                    {
                        a = input[1][0];
                        b = input[1][input[1].Length-1];
                        if(a>b)
                        {
                            var temp = a;
                            a = b;
                            b = temp;
                        }
                    }
                }
                else
                {
                    if(input[0].Length==1)
                    {
                        a = input[0][0];
                        b = a;
                        r = a;
                    }
                    else
                    {
                        a = input[0][0];
                        b = input[0][input[0].Length-1];
                        if (a > b)
                        {
                            var temp = a;
                            a = b;
                            b = temp;
                        }
                        r = a;
                    }
                }
                bool valid = true;
                for (int i = 0; i < data.Count; i++)
                {
                    Element ii = data[i];
                    if((a>=ii.a && a<=ii.b)||(b>=ii.a&&b<=ii.b)||(a<ii.a&&b>ii.b))
                    {
                        valid = false;
                        break;
                    }
                }
                if(valid)
                data.Append(new Element(a, b, r));

                Console.Clear();
            }
            //solve();
        }
        string generate()
        {
            StringBuilder ret = new StringBuilder();
            for (char i = '!'; i <= 255; i++)
            {
                if (i != '\n' && i != 27)
                    ret.Append(i);
            }
            return ret.ToString();
        }
        void solve()
        {
            Console.Write("     ");
            solve(0, data.Count,false) ;
        }
        void solve(int right,int left,bool line)
        {
            int middle = (right + left) / 2;
            if (left - right <= 1)
            {
                if (!line) Console.Write("           ");
                Console.Write($" return '{data[middle].representant}';\n");
                return;
            }
            else if(line)Console.Write("\n     ");
            Console.Write($"if(m < '{data[middle].a}')");
            solve(right, middle,true);
            Console.Write("else ");
            solve(middle, left,false);
        }
        static void Main(string[] args)=>new Program();
        /*
        //implementation of the functional algorithim without identation
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

using System;
using System.Collections.Generic;
using System.Text;

static class ConsoleExt
{
    public static void write(this ConsoleColor c,object str)
    {
        Console.ForegroundColor = c;
        Console.Write(str);
    }
    public static string read(this ConsoleColor c)
    {
        Console.ForegroundColor = c;
        return Console.ReadLine();
    }
}

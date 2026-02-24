using System;
using System.Collections.Generic;
using System.Text;




class DefaultValues
{
    public static int number;
    public static bool flag;
    public static string text;

    public static void ShowDefaults()
    {
        Console.WriteLine("number: " + number);
        Console.WriteLine("flag: " + flag);
        Console.WriteLine("text: " + (text == null ? "null" : text));
    }
}
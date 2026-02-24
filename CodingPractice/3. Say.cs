using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;

class Say
{
    public static string message = "안녕하세요";

    public static void Hi()
    {
        message = "반갑띠.";
        Console.WriteLine(message);
    }
}
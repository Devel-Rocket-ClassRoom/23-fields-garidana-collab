using System;
using System.Collections.Generic;
using System.Text;

class Example
{
    public const double pi = 3.14159;
    public readonly DateTime createdAt = DateTime.Now;

    public void ShowValues()
    {
        Console.WriteLine("원주율: " + pi);
        Console.WriteLine("생성 시간: " + createdAt);
    }
}
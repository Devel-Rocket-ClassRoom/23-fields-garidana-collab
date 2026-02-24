using System;
using System.Collections.Generic;
using System.Text;

class Character
{
    public string name;
    public int level;
    private string name_1;
    private int level_1;
    
    public void ShowStatus()
    {
        Console.WriteLine($"{name}\n{level}");
    }

    public void SetInfo(string name, int level)
    {
        name_1 = name;
        level_1 = level;
        Console.WriteLine($"이름: {name}\n레벨: {level}");
    }
}
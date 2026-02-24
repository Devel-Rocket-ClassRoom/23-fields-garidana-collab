using System;
using System.Collections.Generic;
using System.Text;

class Player
{
    public string name;
    public int health;

    // 4번용 
    public string name_1 = "이름없음";
    public int health_1 = 100;
    public int level_1 = 1;


    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}\n체력: {health}");

    }

    public void ShowStatus_1()
    {
        Console.WriteLine($"이름: {name_1}\n체력: {health_1}\n레벨: {level_1}");
    }


    // 9번용
    public string name_2;
    public static int totalCount;

    public Player(string name)
    {
        name_2 = name;
        totalCount++;
    }
}

class Player_1
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;   // this는 필드 이름과 함수의 매개변수 이름이 같을 시, class의 필드 이름을 칭함/
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine("이름: " + this.name);
        Console.WriteLine("레벨: " + this.level);
    }
    
}

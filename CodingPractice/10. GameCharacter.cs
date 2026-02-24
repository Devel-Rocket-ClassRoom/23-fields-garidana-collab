using System;
using System.Collections.Generic;
using System.Text;

class GameCharacter
{
    string name;
    const int health = 100;
    readonly int attack;
    static int damage;
    int totalCharacter;


    public void ShowStatus(string name, int hp, int attack)
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {hp}/{hp}");
        Console.WriteLine($"공격력: {attack}");
        Console.WriteLine();
    }




    public void Attack(string name, int hp, int dmg)
    {
        name = this.name;
        hp = health;
        dmg = attack;
        int finalHP = hp - dmg;
        Console.WriteLine($"{name}이(가) {dmg} 데미지를 받음! 남은 체력: {hp}");
        
    }
}
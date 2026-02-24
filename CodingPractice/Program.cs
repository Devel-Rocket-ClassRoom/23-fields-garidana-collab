using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;

// README.md를 읽고 코드를 작성하세요.

// 1 
Player p1 = new Player("");
p1.ShowStatus();
Console.WriteLine();

// 2
Character c1 = new Character();
c1.name = "용사";
c1.level = 10;
c1.ShowStatus();
Console.WriteLine();

// 3
Character c2 = new Character();
c2.SetInfo("용사", 10);
Console.WriteLine();

// 4
Player p2 = new Player("");
p2.ShowStatus_1();
Console.WriteLine();

// 5
Say.Hi();
Console.WriteLine();

// 6
Schedule.PrintWeekDays();
Console.WriteLine();

// 7
DefaultValues.ShowDefaults();
Console.WriteLine();

// 8
Counter c1_1 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);
Counter c1_2 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);
Counter c1_3 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);
Console.WriteLine();

// 9
Player p3 = new Player("Warrior");
Player p4 = new Player("Mage");
Player p5 = new Player("Archer");
Console.WriteLine("Total Player: " + Player.totalCount);
Console.WriteLine();

// 10
GameConfig config = new GameConfig();
config.ShowConfig();
Console.WriteLine();

// 11
Example example = new Example();
example.ShowValues();
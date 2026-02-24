using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

class Person
{
    string name = "홍길동";
    const int age = 21;
    readonly string nickName = "길동이";
    string[] sites = { "네이버", "구글" };



    public void ShowProfile()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("나이: " + age);
        Console.WriteLine("닉네임: " + nickName);
        Console.WriteLine("사이트: " + string.Join(", ", sites));
    }
}
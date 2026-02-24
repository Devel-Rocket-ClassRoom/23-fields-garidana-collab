using System;
using System.Collections.Generic;
using System.Text;

class ClassroomManager
{
    const int totalStudent = 5;
    readonly string className;  // 생성자에서 생성하기

    private string[] studentNames;
    private int currentStudent = 0;
    private static int totalClass;

    public ClassroomManager()
    {
        className = "1반";
        string[] students;  // 학생 배열이 무엇?
        totalClass += 1;
    }

    void AddStudent(string name)
    {
        students += name;   /// 
        if (currentStudent > totalStudent)
        {
            Console.WriteLine("오류! 정원초과!");
        }
    }

    void ShowStudent()
    {

    }

    static void ShowTotalClassrooms()
    {

    }
}

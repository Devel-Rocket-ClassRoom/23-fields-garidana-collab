using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;



class Counter
{
    public static int count = 0;

    public Counter()  // 생성자
    {
        count++;
    }
}
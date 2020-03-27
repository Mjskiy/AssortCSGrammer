using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_StaticClass
{
    static class StClass
    {
        // static 클래스는 정적 멤버변수와 멤버 함수만 가질 수 있다 .
        //int Test = 100;
    }

    class Player
    {
        // 함수의 위치는 문법적으로 어디에 있건 상관없다 .

        static void Main(string[] args)
        {
            Console.WriteLine("정적 멤버 함수와 관련해 배우고 있어요 !");
        }
    }

    class Program
    {
        
    }
}

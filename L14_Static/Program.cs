using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_Static
{
    class SidePlayer
    {
        // 정적멤버변수 : 객체에 귀속된것이 아니라 클래스 그 자체에 귀속된다
        // 메모리가 데이터 영역에 올라간다. 
        static public int PlayerCounter;

        // 멤버변수 : 객체 하난하나가 자신의 것을 가진다.
        public int X = 0;
        public int Y = 0;
        public int HP = 0;

        public void Gravity()
        {
            Y -= 200;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // 게임내에서 하나만 존재하며
            // 일반적으로 클래스 내부에서 모든 객체가 공유하고 싶은 변수를 만들때 사용한다
            SidePlayer.PlayerCounter = 3;
            SidePlayer NewPlayer1 = new SidePlayer();
            SidePlayer NewPlayer2 = new SidePlayer();
            SidePlayer NewPlayer3 = new SidePlayer();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_StaticFunction
{

    public class Player
    {
       
        //객체화를 하지 않아도 클래스 내부에서 static은 접근제한 지정자에 자유롭다 (private에도 접근 가능하다. )
        public static void PVP(Player _Left, Player _Right)
        {
            _Left.HP -= _Right.AT;
            _Right.HP -= _Left.AT;
        }

        private int AT = 100;
        private int HP = 100;

        public void Damage(int _Damage)
        {
            HP -= 100;
        }


        public void Damage(Player _Other)
        {
            // 자기자신의 레퍼런스는 자신의 내부에서 모두 PUBLIC인 상태이다.  
            HP -= _Other.AT;
        }
    }


    public class Monster
    {
        private int AT = 100;


        //public static void PVP(Player _Left, Player _Right)
        //{
        //    _Left.HP -= _Right.AT;
        //    _Right.HP -= _Left.AT;
        //}
    }

    class Program
    {

        // 메인 함수로 클래스에 속한 정적함수이다. 
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            // 정적멤버함수 : 클래스에 속하지만 객체를 만들지 않고 사용한다. 
            Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer1.Damage(100);

            // public인 멤버변수라도 이렇게 사용해야 한다. 
            //NewPlayer.
        }
    }
}

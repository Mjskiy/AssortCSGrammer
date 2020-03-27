using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_This
{
    class Player
    {
        private  int HP =100;

        //public void Damage(int _Dmg)
        //{
        //    //HP가 NewPlayer2의 HP인지 어떻게 알수 있지?
        //    //HP -= _Dmg;

        //    this.HP -= _Dmg;

        //}


        public static void Damage(Player _This, int _Dmg)
        {
            //static 멤버함수는 객체를 만들지 않고도 사용할 수 있으므로 
            // 자신이라는 개념이 없는 함수이다. 
            //this. 을 지원하지 않는다. 
            _This.HP -= _Dmg;

            
        }

        // 멤버함수의 호출에는 프로그램이 그 대상을 대신 넣어줌 

        public void Heal(/*Player this, */ int Heal)
        {
           
            //this.HP 처럼 this를 생략하게 됨
            HP += Heal;
        }


        static private int StTest = 100;

        public static void PVP(Player _Left, Player _Right)
        {
            // 객체에 영향을 받지 않는것이 정적멤버함수 및 멤버 변수 
            // HP = 1000;

            StTest = 50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            // NewPlayer2.Damage(100);

            

            Player.Damage(NewPlayer1, 100);

            Player.PVP(NewPlayer1, NewPlayer2);

        }
    }
}

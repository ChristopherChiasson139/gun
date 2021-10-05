using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    class Program
    {
        static int score;
        static int health; // 0..100
        static int gun;
        static string mc;
        static string hp;


        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("------HUD-------");
            Console.WriteLine("Health = " + hp);
            Console.WriteLine("Score = " + score);
            Console.WriteLine("Gun = " + mc);
            Console.WriteLine("----------------");
        }
        static void SetHealthStatus(int health)
        {
            if (health == 0)
            {
                hp = "Gamer";
            }

            if (health == 1)
            {
                hp = "Heathly";
            }

            if (health == 2)
            {
                hp = "Hurt";
            }

          

            if (health == 3)
            {
                hp = "look like a zombie";
            }

            if (health == 4)
            {
                hp = "fortnite";
            }

        }
        static void SetGunName(int gun)
        {
            

            
            if (gun == 0)
            {
                mc = "pug gun";
            }

            if (gun == 1)
            {
                mc = "funny gun";
            }

            if (gun == 2)
            {
                mc = "BFG";
            }

            if (gun == 3)
            {
                mc = "RPG";
            }

            if (gun == 4)
            {
                mc = "Shrek";
            }

            if (gun == 5)
            {
                mc = "Laser";
            }
        }
        static void AddScore(int point)
        {
            score = score + point;
        }

        static void TakeDamage(int damage)
        {
            health = health + damage;
        }



        static void Main(string[] args)
        {
            int pointsEarned;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("start");
            SetGunName(0);
            SetHealthStatus(health);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            pointsEarned = 5;
            Console.WriteLine("you kill a zombies (and 7 pugs in the process) you get " + pointsEarned + " ponts");
            Console.ReadKey(true);
            AddScore(pointsEarned);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you are out of pugs you need a new gun");
            Console.ReadKey(true);
            SetGunName(1);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you shoot a zombie,he laughs himself to death,you get 5 ponts");
            Console.ReadKey(true);
            AddScore(5);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you are all laugh out you need a new gun");
            Console.ReadKey(true);
            SetGunName(2);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you don't know what a BFG is you need to look for a new gun a zombie hit you hp-10");
            Console.ReadKey(true);
            SetHealthStatus(1);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("a zombie farted on you hp-10");
            Console.ReadKey(true);
            SetHealthStatus(2);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("a zombie kiss you hp-10");
            Console.ReadKey(true);
            SetHealthStatus(3);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you got an RPG");
            Console.ReadKey(true);
            SetGunName(3);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you uesed the RPG on a hoard of zombies....at point blank range (you get 70 ponts and hp-10)");
            Console.ReadKey(true);
            SetHealthStatus(4);
            AddScore(70);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you get a hath pack hp+30");
            Console.ReadKey(true);
            SetHealthStatus(1);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you equip shrek");
            Console.ReadKey(true);
            SetGunName(4);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("shrek makes a wall in to a door  (you equip the Laser)");
            Console.ReadKey(true);
            SetGunName(5);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you see the boss (baby) you start charging your laser and tank a hit form the boss (hp-30)");
            Console.ReadKey(true);
            SetHealthStatus(4);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("the laser is charg tou kill the boss baby in one hit (thank you) you get 100 ponts");
            Console.ReadKey(true);
            AddScore(100);
            ShowHUD();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you win");



            Console.ReadKey(true);
        }
    }
}

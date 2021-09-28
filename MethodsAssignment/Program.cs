using System;

namespace MethodsAssignment
{
    class Program
    {
        static string Role = "Fighter";

        static string Race = "Elf";

        static int Level = 1;

        static float exp = 0f;

        static int health = 10;

        static int lives = 3;

        static float expMultip = 2.5f;

        static float levelMultiplier = 2.2f;

        static void EXPMultiplier(int expM)
        {
            exp = expM * expMultip + exp;
        }

        static void Damage(int damage)
        {
            health = health - damage;
        }

        static void Death()
        {
            if (health <= 0)
            {
                lives = lives - 1;
                health = 10;
                Console.WriteLine("");
                Console.WriteLine("You lost a life!");
                Console.WriteLine("");
            }

        }

        static void ShowHUD()
        {
            LevelUp();
            Death();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|" + "Class:" + Role + "                        |");
            Console.WriteLine("|" + "Race:" + Race + "                             |");
            Console.WriteLine("|" + "Level:" + Level + "  " + "Exp:" + exp + "                       |");
            Console.WriteLine("|" + "Current Health:" + health + "  " + "Current Lives:" + lives + "   |");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void LevelUp()
        {
            if (exp >= 100) 
            {
                exp = exp - 100;
                Level = Level + 1;
                Console.WriteLine("");
                Console.WriteLine("You Leveled up!");
                Console.WriteLine("");
            }

        }


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Welcome to Eirithyl");
            Console.WriteLine("");
            ShowHUD();

            Console.WriteLine("You killed 3 Goblins!");
            Console.WriteLine("");
            Console.WriteLine("You earned 20 exp!");
            EXPMultiplier(20);
            Console.WriteLine("");
            Console.WriteLine("Your Multiplier of 2.5x was applied.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


            ShowHUD();

            Console.WriteLine("You get in a fight with your best friend!");
            Console.WriteLine("");
            Console.WriteLine("You take 4 damage after");
            Damage(4);
            Console.WriteLine("");
            Console.WriteLine("You gained 50 EXP!");
            Console.WriteLine("");
            Console.WriteLine("Your Karma went down...");
            Console.WriteLine("");
            Console.WriteLine("Your Multiplier of was changed to 1.75x");
            expMultip = 1.75f;
            EXPMultiplier(50);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


            ShowHUD();

            Console.WriteLine("You foolishly try to fight a bear!");
            Console.WriteLine("");
            Console.WriteLine("You take 12 damage!");
            Damage(12);
            Console.ReadKey();

            ShowHUD();


        }
    }
}

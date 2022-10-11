using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static int health;
        static void Main(string[] args)
        {
            health = 100;

            ShowHud(health);
            Console.WriteLine();
            TakeDamage(20, health);
            Console.WriteLine();
            ShowHud(health);

            Console.ReadKey(true);
        }

        static void ShowHud(int health)
        {
            Console.WriteLine("The spoiled child has " + health);

            if (health == 100)
            {
                Console.WriteLine("The Child has Perfect health");
            }

            if (health <= 99)
            {
                if (health >= 75) 
                {
                    Console.WriteLine("The Child is Healthy");
                }
                
            }

            if (health <= 75)
            {
                if (health >= 50)
                {
                    Console.WriteLine("The Child is Hurt");
                }

            }

            if (health <= 50)
            {
                if (health >= 10)
                {
                    Console.WriteLine("The Child is Badly hurt");
                }
            }

            if (health <= 10)
            {
                if (health >= 0)
                {
                    Console.WriteLine("The Child is in imminent danger");
                }
            }
        }

        static void TakeDamage(int damage, int hp)
        {
            Console.WriteLine("You dealt " + damage + " damage to the spoiled child!");
            health = hp - damage;
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(300);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {

                int damageDealt = attacker.CalcDamage();
                
                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
               
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {

            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }//end class
}//end namespace

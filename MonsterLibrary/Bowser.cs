using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Bowser : Monster
    {
        public bool IsScaly { get; set; }

        public Bowser()
        {
           
        }

        public Bowser(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaly) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsScaly = isScaly;
        }//end FQ CTOR

    
        public override int CalcBlock()
        {
            int result = Block;
            if (IsScaly)
            {
                result += Block / 2;
            }
            return result;
        }//end override int

        public override string ToString()
        {
            return base.ToString() + (IsScaly ? "Scaly!" : "He is definitely scaly!...");
        }//end override string


    }//end class
}//end namespace

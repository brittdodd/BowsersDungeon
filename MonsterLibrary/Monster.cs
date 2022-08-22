using DungeonLibrary;

namespace MonsterLibrary

{
    public class Monster : Character
    {
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        private int _minDamage;

        public int MinDamage
        {
            get { return _minDamage; }
            //can't be more than maxdamage, can't be less than 1
            set
            {
                if (value > MaxDamage || value < 1)
                {
                    _minDamage = 1;
                }
           
                else
                {
                    _minDamage = value;
                }
                
            }//end set
        }//end MinDamage

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }//end FQ CTOR
        
        public Monster()
        {
            
            Name = "Bowser";
            MaxLife = 25;
            Life = 25;
            HitChance = 30;
           Block = 8;
            MaxDamage = 10;
            MinDamage = 2;
            Description = @"The King of the Koopalings is said to be fierce and highly intimidating...
    
        //INSERT BOWSERS IMAGE HERE
";
        }//End Default CTOR
        public override string ToString()
        {
            return $@"
********* MONSTER *********
{Name}
Life: {Life} of {MaxLife}
Damage: {MinDamage} to {MaxDamage}
Block: {Block}
Description:
{Description}
";
        }


        public override int CalcDamage()
        {
            //return base.CalcDamage();//returns 0, not what we want.
            return new Random().Next(MinDamage, MaxDamage + 1);// + 1 because it's exclusive
        }//end CalcDamage()

        public static Monster GetMonster()
        {
            Monster kingKoopa = new Monster();
            Monster antagonist = new Monster("Wario", 17, 17, 30, 10, 5, 2, "He is a muscular, hot-tempered, and greedy man!");
            Monster Magikoopa = new Monster("Kamek", 15, 15, 20, 10, 15, 1, "He's old, but highly powerful Magikoopa!");
            Monster mischievous = new Monster("Waluigi", 25, 25, 50, 20, 8, 2, "He's said to be mischievous and cunning man! ");
            Monster skeletonBoy = new Monster("Shy Guy", 25, 25, 50, 20, 8, 2, "He's short and stocky, but man is he clever!");

            List<Monster> monsters = new List<Monster>()
            {
                kingKoopa, kingKoopa, kingKoopa, kingKoopa,
                antagonist, antagonist, antagonist,
                Magikoopa, Magikoopa,
                mischievous, mischievous,
                skeletonBoy, skeletonBoy

            };
            
            return monsters[new Random().Next(monsters.Count)];
        }//end GetMonster()
   }//end class
}//end namespace
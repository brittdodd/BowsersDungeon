using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        private Race _characterRace;
        
        public Race CharacterRace
        {
            get { return _characterRace; }
            set { _characterRace = value; }
        }//end CharacterRace

      
        private Weapon _equippedWeapon;
       
        public Weapon EquippedWeapon
        {
            
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }//end EquippedWeapon

        public Player(string name, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon)
            : base(name, hitChance, block, maxLife, life)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            
            switch (CharacterRace)
            {
                case Race.Mario:
                    MaxLife += 15;
                    Life += 15;
                    HitChance += (HitChance / 20);
                    Block += 4;
                    break;
                case Race.Luigi:
                    MaxLife += 15;
                    Life += 15;
                    HitChance += 6;
                    Block += 4;
                    break;
                case Race.Yoshi:
                    MaxLife += 12;
                    Life += 12;
                    HitChance += 5;
                    Block += 4;
                    break;
                case Race.Toad:
                    MaxLife += 10;
                    Life += 10;
                    HitChance += (HitChance / 20);
                    Block += 3;
                    break;
            }//end switch

            

        }//end FQCTOR

        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Mario:
                    description = "Mario";
                    Console.WriteLine(@"You Chose Mario!
                                                                      
                     ████▓▓▓▓▓▓████░░░░░██
                    ██▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░██
                  ██▓▓▓▓▓▓████████████░░░░██
                ██▓▓▓▓▓▓████████████████░██
                ██▓▓████░░░░░░░░░░░░██████
              ████████░░░░░░██░░██░░██▓▓▓▓██
              ██░░████░░░░░░██░░██░░██▓▓▓▓██
            ██░░░░██████░░░░░░░░░░░░░░██▓▓██
            ██░░░░░░██░░░░██░░░░░░░░░░██▓▓██
              ██░░░░░░░░░███████░░░░██████
                ████░░░░░░░███████████▓▓██
                  ██████░░░░░░░░░░██▓▓▓▓██
                ██▓▓▓▓██████████████▓▓██
              ██▓▓▓▓▓▓▓▓████░░░░░░████
            ████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
            ████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
            ██████▓▓▓▓▓▓▓▓██░░░░░░████████
              ██████▓▓▓▓▓▓████████████████
                ██████████████████████▓▓▓▓██
              ██▓▓▓▓████████████████▓▓▓▓▓▓██
            ████▓▓██████████████████▓▓▓▓▓▓██
            ██▓▓▓▓██████████████████▓▓▓▓▓▓██
            ██▓▓▓▓██████████      ██▓▓▓▓████
            ██▓▓▓▓████               ██████
              ████


");
                    break;
                case Race.Luigi:
                    description = "Luigi";
                    Console.WriteLine(@"You Chose Luigi!

                                      
");
                    break;
                case Race.Toad:
                    description = "Toad";
                    Console.WriteLine(@"You Chose Toad!

                
                              ..:^^^^^^^:::....                    
                          .:^^^::......::::. ...:^:.               
                       ::^^:.             .:^     .::.             
                     :^.^:                  .~.      .~^           
                   :^. :^                    .^       :!^          
                  ::   ^                      ~        ~.~         
                 :.    ^                     .^        ::.~        
                ::     ::                   .~.         ^ ^.       
                !       ^^                 :^.          :~.^       
                ?:       :~:.           .^^:             ^^^       
                !^.        .::::.::.:::::.                ^^       
                ^^:.            ....                      ::       
                .! ^                                     :~        
                 :~.^                ...:^^::::^:::     :^         
                  :!^^           .::::...  .J7.   .~  .^:          
                   .^7:        :^:.7~      .B@Y    :~:.::.:^~..    
                     .^~^.    ^:  :#&:      ^57     ~. ^.:..^~~    
                        :^:::.!.   ?P.              ^ .^     ^~.   
                            ..^~        .:~!?5J    ^^:.  ..::::.   
                               :~.   :JB#PJJYG^  .!7:   ^:.        
                                .^^.   ~!...:..:7!^   .^.          
                                   .~~^.:::::~^.J:   :^            
                                  .!~~.      :. :.^^!:             
                               .:^!^~.       .^ !.  :!.            
                         ......:.^:~~.::::::..7 .~   .~:           
                        .^...   ~^:!          :~ :^...:~^          
                          ..~.::~^~.           :^ ...::^~          
                            ..  .!.             .:::::.:~          
                                 ~                     ^:          
                              :^:^:.                 .~^           
                             ~:    :^:.           .:::::.          
                            :^       .....^^^^^:::..    ^:         
                             ~:.      ..::~.:^           ~.        
                              .::^^^:::..    ^:          ^.  
                                              ^^.      .^^ 
                                                ^^:.::::    
            
");
                    break;
                case Race.Yoshi:
                    description = "Yoshi";
                    Console.WriteLine(@"You Chose Yoshi!


            ───────────────────────────────
            ───────────────████─███────────
            ──────────────██▒▒▒█▒▒▒█───────
            ─────────────██▒────────█──────
            ─────────██████──██─██──█──────
            ────────██████───██─██──█──────
            ────────██▒▒▒█──────────███────
            ────────██▒▒▒▒▒▒───▒──██████───
            ───────██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███─
            ──────██▒▒▒▒─────▒▒▒▒▒▒▒▒▒▒▒▒█─
            ──────██▒▒▒───────▒▒▒▒▒▒▒█▒█▒██
            ───────██▒▒───────▒▒▒▒▒▒▒▒▒▒▒▒█
            ────────██▒▒─────█▒▒▒▒▒▒▒▒▒▒▒▒█
            ────────███▒▒───██▒▒▒▒▒▒▒▒▒▒▒▒█
            ─────────███▒▒───█▒▒▒▒▒▒▒▒▒▒▒█─
            ────────██▀█▒▒────█▒▒▒▒▒▒▒▒██──
            ──────██▀██▒▒▒────█████████────
            ────██▀███▒▒▒▒────█▒▒██────────
            █████████▒▒▒▒▒█───██──██───────
            █▒▒▒▒▒▒█▒▒▒▒▒█────████▒▒█──────
            █▒▒▒▒▒▒█▒▒▒▒▒▒█───███▒▒▒█──────
            █▒▒▒▒▒▒█▒▒▒▒▒█────█▒▒▒▒▒█──────
            ██▒▒▒▒▒█▒▒▒▒▒▒█───█▒▒▒███──────
            ─██▒▒▒▒███████───██████────────
            ──██▒▒▒▒▒██─────██─────────────
            ───██▒▒▒██─────██──────────────
            ────█████─────███──────────────
            ────█████▄───█████▄────────────
            ──▄█▓▓▓▓▓█▄─█▓▓▓▓▓█▄───────────
            ──█▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓█──────────
            ──█▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓█──────────
            ──▀████████▀▀███████▀──────────

    
");
                    break;
                default:
                    break;
            }
            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" + description;
        }//ToString() override

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
     
            Random rand = new Random();

        
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;

            
        }//end override 

    }//end class
}//end namespace
 
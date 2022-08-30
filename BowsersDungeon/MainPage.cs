using DungeonLibrary;
using MonsterLibrary;
using System.Media; 

namespace BowsersDungeon
{
    internal class MainPage
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome you have entered into Bowsers Dungeon!

                           o
                      _====|     o
                       ====|_====|
               _====|      | ====|  I-I-I-I-I                  _ _ _ _ _ _
   _ _ _ _ _ _  ====|      |     |   \ ` ' /                   I-I-I-I-I-I
   I-I-I-I-I-I      |      |     |    |.   |                    \ `   '_/
    \ `   '_/       |     / \    |    | /^\|                     |__ [],|
     [*]  __|       ^    / ^ \   ^    | [*]|                    _|______|_
     |__   ,|      / \  /    `\ / \   | ===|                   <=-=-==-=-=>
  ___| ___  |__   /    /=_=_=_=\   \  |,  _|                    \__   _'_/
  I_I__I_I__I_I  (====(_________)___) |____| ___   Bowser's      |.   _ |
  \-\--|-|--/-/  |     |  [*I__| I_I__I____I_I_I    Dungeon      |   _  |
   |[]      '|   |     | __  . |  \-\--|-|--/-/                  |`    '|
   |.      ' | __| ___ |__ ___ |__ |---------|                   |   [] |
  / \  []   .|_| |_| |_| |_| |_| |_| []   [] |                   | `    |
 (===)      .|-=-=-=-=-=-=-=-=-=-=-|        / \                  |[]    |
 | []|`   [] | . . . . . . . . .   |-      (===)                 |`   __|
 | []| `     |/////////\\\\\\\\\\  |__.    |[] |                /|      |
 <===>     ' |||||           ||||  |  []   <===>-I-I-I-I-I-I-I-I-| `  I-|
  \I/    1-- |||||           ||||  | .  '   \i/    .  |          |     _|
   |      . _|||||           ||||  |         |            ----'  |`    .|
../|',v,.,,,.|||||/_________\||||,/|.,,.Y,,..|\__ 
");
            #region Input Music
            //SoundPlayer musicPlayer = new SoundPlayer();
            //musicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Music.wav";
            //musicPlayer.PlayLooping();
            #endregion

            int score = 0;

            Console.Write("Hello There! What is your name? ");
            string userName = Console.ReadLine();

            Console.Clear();
            #region Race Selection
            Weapon iceBlaster = new Weapon(8, 1, "Freeze Ray", 10, false, WeaponType.iceBlasters);
            
            var races = Enum.GetValues(typeof(Race));
            int index = 1;
            foreach (var race in races)
            {
                Console.WriteLine($"{index}) {race}");
                index++;
            }
            Console.WriteLine("Please select which Character you would like to be!");
            int userAnswer = int.Parse(Console.ReadLine()) - 1;
            Race userCharacter = (Race)userAnswer;
            Console.WriteLine(userCharacter);

            
            Player player = new Player(userName, 70, 5, 40, 40, userCharacter, iceBlaster);
            Console.WriteLine($"{player.Name}, you chose {userCharacter}!, your journey can now begin!\n\n");
            #endregion

            Monster monster = Monster.GetMonster();
            Console.WriteLine("In this room you find...." + monster.Name);
            Console.WriteLine();
            bool reload = false;

            Random rand = new Random();
            bool exit = true;
            bool bigLoop = true;
            bool smallLoop = false;

           do
            {

                Console.WriteLine(GetRoom());

                do
                {
                    Console.WriteLine("Please select your fate....\n\n");
                    Console.WriteLine("A) Attack\n" +
                                      "B) Run Away\n" +
                                      "C) Player Info\n" +
                                      "D) Monster Info\n" +
                                      "E) Exit\n");
                    string userChoice = Console.ReadLine().ToLower();

                    Console.Clear();

                    switch (userChoice)
                    {
                        case "a":
                        case "attack":
                            int randattk = rand.Next(1, 10);
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                score++;
                                Console.WriteLine($"You attacked and killed {monster.Name}!\n\n");
                                Console.Beep(700, 500);
                                reload = true;

                            }
                            if (player.Life <= 0)
                            {
                                Console.WriteLine("You have been injured you need a power up!");
                                smallLoop = true;
                            }
                            break;
                            Console.Clear();
                        case "b":
                        case "run away":
                            Console.WriteLine("You should run...RUN FASTER!....\n\n");
                            Console.WriteLine($"{monster.Name} attacked while you fled!\n\n");
                            Combat.DoAttack(monster, player);                                                    
                            reload = true;
                            
                            break;

                        case "c":
                        case "player info":
                            Console.WriteLine("Player Information");
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters Defeated: " + score);
                            break;
                            Console.Clear();
                        case "d":
                        case "monster info":                            
                            Console.WriteLine("Monster Information\n\n");
                            Console.WriteLine(monster);
                            break;
                        case "x":
                        case "e":
                        case "exit":
                            Console.WriteLine("You're leaving...already?....I feel like you can do better....");
                            bigLoop = false;

                            break;

                        default:
                            Console.WriteLine("Please try again.");
                            break;
                    }//end switch

                    if (smallLoop)
                    {
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadLine();
                        Console.Clear();
                    }//end if
                } while (smallLoop == true && bigLoop == true);
            } while (bigLoop == true);
        }//end Main
        private static string GetRoom()
        {


            //*********************************************  ROOMS ********************************************************




            string[] rooms =
                {"As you travel down the long moat bridge, you will need to keep an eye out for Kamek, he throws fireballs and they are lethal. Continue through until you have reached a potential power up box, there you will find Yoshi. Climb onto his back and ride down the bridge to a pipeline that will take you into a greenland escape.\n\n",
                "As you travel down the pipeline, you enter into a dark room with candles lit, you progress you see sharp blocks and swords sticking out of the walls, carefully make your way through the obstacles and move your way up the room, you will need to climb onto shelves and staircases in order to find Bowser.\n\n",
                "Continue down the main hall and turn right into a jailcell, as you progress you will see a special box you need to open in order to receive an advantage in the game, then you can continue to move past the Boo's and move down the pipe towards Browsers Layer.\n\n",
                "As you enter down the main bridge over the lava pit, you will need to keep clear of Dry Bones and all his buddies, keep going till you get to the secret door hidden beneath the spiraling sword fan.\n\n"

            };//end string rooms

            Random rand = new Random();
            int nbr = rand.Next(rooms.Length);
            string room = rooms[nbr];
            return room;

            
        }//end Main()
    }//end class
}//end namespace
using System;

class Program
{
    static void Main(string[] args)
    {

        string logo = @"   
       ▄████▄  ██░ ██ ▒█████  ██▓▄████▄ ▓█████ ███▄ ▄███▓▄▄▄      ██ ▄█▓█████ ██▀███   ██████
      ▒██▀ ▀█ ▓██░ ██▒██▒  ██▓██▒██▀ ▀█ ▓█   ▀▓██▀█▀ ██▒████▄    ██▄█▒▓█   ▀▓██ ▒ ██▒██    ▒
     █    ▄▒██▀▀██▒██░  ██▒██▒▓█    ▄▒███  ▓██    ▓██▒██  ▀█▄ ▓███▄░▒███  ▓██ ░▄█ ░ ▓██▄
      ▒▓▓▄ ▄██░▓█ ░██▒██   ██░██▒▓▓▄ ▄██▒▓█  ▄▒██    ▒██░██▄▄▄▄██▓██ █▄▒▓█  ▄▒██▀▀█▄   ▒   ██▒
      ▒ ▓███▀ ░▓█▒░██░ ████▓▒░██▒ ▓███▀ ░▒████▒██▒   ░██▒▓█   ▓██▒██▒ █░▒████░██▓ ▒██▒██████▒▒
      ░ ░▒ ▒  ░▒ ░░▒░░ ▒░▒░▒░░▓ ░ ░▒ ▒  ░░ ▒░ ░ ▒░   ░  ░▒▒   ▓▒█▒ ▒▒ ▓░░ ▒░ ░ ▒▓ ░▒▓▒ ▒▓▒ ▒ ░
        ░  ▒   ▒ ░▒░ ░ ░ ▒ ▒░ ▒ ░ ░  ▒   ░ ░  ░  ░      ░ ▒   ▒▒ ░ ░▒ ▒░░ ░  ░ ░▒ ░ ▒░ ░▒  ░ ░
      ░        ░  ░░ ░ ░ ░ ▒  ▒ ░          ░  ░      ░    ░   ▒  ░ ░░ ░   ░    ░░   ░░  ░  ░";



        int screenWidth = Console.WindowWidth;
        int screenHeight = Console.WindowHeight;
        int logoPadding = Math.Max((screenHeight - logo.Split('\n').Length) / 2, 0);

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var i = 0;
        foreach (string line in logo.Split('\n'))
        {
            Console.SetCursorPosition(Math.Max((screenWidth - line.Length) / 2, 0), i);
            Console.WriteLine(line);
            i++;
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        logoPadding = 5;

        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i);
        Console.Write("1. ");
        Console.ResetColor();
        Console.Write("Play");

        //Console.ForegroundColor = ConsoleColor.DarkGreen;
        //Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i + 1);
        //Console.Write("2. ");
        //Console.ResetColor();
        //Console.Write("Help");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i + 2);
        Console.Write("3. ");
        Console.ResetColor();
        Console.Write("Info");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write("Copyright\u00A9: ");
        Console.ResetColor();
        Console.Write("Colin van Steenhoven");

        Console.SetCursorPosition(Math.Max((screenWidth - 15) / 2, 0), logoPadding + i + 3);
        Console.Write("Enter your choice: ");
        string? choice1 = Console.ReadLine();

        Console.ResetColor();

        if (choice1 != null)
        {
            switch (choice1)
            {
                case "1":
                    StartGame();
                    break;
                //case "2":
                //ShowHelp();
                //break;
                case "3":
                    ShowInfo();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
    static void ShowInfo()
    {
        Console.WriteLine("This is a pixel adventure game. Explore the world, find treasures, and defeat monsters.");
    }

    static void StartGame()
    {
        Console.WriteLine("Starting the game...");
        Console.Clear();

        string asciiArt = @"
                       ,-.^._                 _
                     .'      `-.            ,' ;
          /`-.  ,----'         `-.   _  ,-.,'  `
       _.'   `--'                 `-' '-'      ;
      :                         o             ;    __,-.
      ,'    *               Coming soon       ;_,-',.__'--.
     : You are here                          ,--```    `--'
     :                                      ;
     :                                      :
     ;                                      :
    (                                       ;
     `-.                           o      ,'
       ;                    Check Part II :
     .'                             .-._,'
   .'                               `.
_.'                                .__;
`._                  o            ;
   `.             Coming soon    :    ,---------------------.
     `.               ,..__,---._;    |    AFGHANISTAN      |
       `-.__         :                | Capital: Herat      |
            `.--.____;                | Pop: 48542565       |
                                      | Area: 456325 sq.mi. |
                                      |      (196194 sq.km.)|
                                      `---------------------'";


        Console.WriteLine("let's look at the map, press enter to continue...");

        Console.ReadLine();

        Console.Clear();

        Console.WriteLine(asciiArt);

        bool continueGame = true;

        while (continueGame)
        {
            Console.WriteLine("You have come from afar and find yourself in a place called Herat.");
            Console.WriteLine("Herat is a jungle-like place with many secrets to discover. Let's begin!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("After entering Herat, you come across a jungle temple... It looks intriguing.");
            Console.WriteLine("Do you want to enter the temple? (yes/no)");

            string choice = ValidateInput("yes", "no");

            switch (choice)
            {
                case "yes":
                    EnterTemple();

                    choice = ValidateInput("left", "right");

                    switch (choice)
                    {
                        case "left":
                            LeftToDoor();

                            choice = ValidateInput("lockpick", "go back");

                            if (choice == "lockpick")
                            {
                                continueGame = PickLock();
                            }
                            else
                            {
                                ChickenBok();
                            }
                            break;

                        case "right":
                            continueGame = DragonEncounter1();
                            break;
                    }
                    break;

                case "no":
                    continueGame = DontEnterTemple();
                    break;
            }
        }
    }

    static string ValidateInput(params string[] validOptions)
    {
        string choice = Console.ReadLine().ToLower();

        while (Array.IndexOf(validOptions, choice) == -1)
        {
            Console.WriteLine("Invalid choice. Choose again!");
            choice = Console.ReadLine().ToLower();
        }

        return choice;
    }
    //static void ShowHelp()
    //{
        //Console.Clear();
        //Console.WriteLine("=== Game Help Menu ===\n");
        //Console.WriteLine("Welcome to the Help Menu. Here, you will find useful information to navigate and enjoy the game.");
        //Console.WriteLine("Type 'exit' at any time to return to the game.\n");

        //Console.WriteLine("1. How to Play");
        //Console.WriteLine("2. Game Controls");
        //Console.WriteLine("3. Tips");
        //Console.WriteLine("4. Exit Help (Resume Game)\n");

        //Console.Write("Enter your choice: ");

        //string helpChoice = Console.ReadLine().ToLower();

        //switch (helpChoice)
        //{
        //case "1":
        //Console.Clear();
        //Console.WriteLine("=== How to Play ===\n");
        //Console.WriteLine("You find yourself in the mysterious jungle temple of Herat.");
        //Console.WriteLine("Explore the temple, make choices, and uncover its secrets.");
        //Console.WriteLine("Your objective is to survive the adventure and collect treasures.");
        //Console.WriteLine("You can interact with the game using simple text commands.\n");
        //break;
        //case "2":
        //Console.Clear();
        //Console.WriteLine("=== Game Controls ===\n");
        //Console.WriteLine("- Type '1' to Start the Game.");
        //Console.WriteLine("- Type '2' to View Game Info.");
        //Console.WriteLine("- Type 'help' to Access This Help Menu.");
        //Console.WriteLine("- Type 'exit' to Return to the Game.\n");
        // break;
        //case "3":
        //Console.Clear();
        //Console.WriteLine("=== Tips ===\n");
        //Console.WriteLine("1. Be cautious and think carefully about your choices.");
        //Console.WriteLine("2. Explore different paths and options to discover secrets.");
        //Console.WriteLine("3. You may find items or weapons to aid you on your journey.");
        //Console.WriteLine("4. Remember, you can always return to this help menu by typing 'help'.");
        //Console.WriteLine("5. Enjoy the adventure and have fun!\n");
        //break;
        //case "4":
        //Console.Clear();
        //Console.WriteLine("Returning to the game...");
        //return;
        //default:
        //Console.Clear();
        //Console.WriteLine("Invalid choice. Please choose a valid option.");
        //break;
        //}
        //}
        static bool FightDragon()
        {
            Console.Clear();
            Console.WriteLine("You engage in a battle with the dragon, and after an epic fight, you manage to defeat the dragon!");
            Console.WriteLine("You have survived the adventure and defeated the dragon.");
            Console.WriteLine("After the battle, you discover a secret door behind the dragon.");
            Console.WriteLine("You open the door and find a large chest full of goods and diamonds!");
            Console.WriteLine("Congratulations, you have won the game!");

            Console.WriteLine("You return to the civilized world with the large chest full of treasures and diamonds.");
            Console.WriteLine("You become a legend, and Herat will always remain in your memories.");
            Console.WriteLine("Thanks for playing!");
            return false;
        }
        static void TakeSword()
        {
            Console.Clear();
            Console.WriteLine("Fight the dragon or back out of the temple.\n");
            Console.WriteLine("You have taken the sword and feel much more powerful.");
            Console.WriteLine("You return to the dark room and come face to face with the gigantic dragon.");
            Console.WriteLine("With the sword in your hands, you are determined to defeat the dragon!");
            Console.WriteLine("What do you want to do? (fight/go back)");
        }
        static bool DontEnterTemple()
        {
            Console.Clear();
            Console.WriteLine("You decide not to enter the temple and leave.");
            Console.WriteLine("The adventure ends here. Thanks for playing!");
            return false;
        }

        static void EnterTemple()
        {
            Console.Clear();
            Console.WriteLine("Objective: Explore the temple\n");
            Console.WriteLine("You enter the temple. The temple creaks, and strange sounds come from strange places.");
            Console.WriteLine("You take a few steps and see a door to your left and an open room to your right (The room looks a bit dangerous).");
            Console.WriteLine("Do you want to go left through the door, or do you want to go right into the open room? (left/right)");
        }

        static void LeftToDoor()
        {
            Console.Clear();
            Console.WriteLine("Objective: Pick the door's lock or back out\n");
            Console.WriteLine("You go left and approach the door... It seems to be locked, but luckily you brought your lockpick set.");
            Console.WriteLine("Do you want to try to pick the lock, or do you want to take a step back and reconsider your choice? (lockpick/go back)");
        }

        static void ChickenBok()
        {
            Console.Clear();
            Console.WriteLine("You decide to go back and reconsider your choice.");
        }

        static bool DragonEncounter1()
        {
            Console.Clear();
            Console.WriteLine("You go right into the open room, where even stranger sounds are coming from.");
            Console.WriteLine("Inside the room, you come face to face with a gigantic dragon!");
            Console.WriteLine("You were not prepared, and the dragon defeats you. Game over!");
            return false;
        }

        static bool PickLock()
        {
            Console.Clear();
            Console.WriteLine("Objective: Take the treasure, sword or back out.\n");
            Console.WriteLine("Using your lockpick skills, you manage to open the door.");
            Console.WriteLine("You enter a dark, secret passage deep within the temple.");
            Console.WriteLine("As you continue, you hear mysterious whispers and feel an ominous presence.");
            Console.WriteLine("At the end of the passage, you come to an ancient room with a sword and a gigantic, gleaming treasure!");
            Console.WriteLine("What do you want to do? (take sword/take treasure/go back)");

            var choice = ValidateInput("take sword", "take treasure", "go back");

            if (choice == "take sword")
            {
                Console.Clear();
                Console.WriteLine("You decide to take the sword and now have a powerful weapon in your hands!");
                Console.WriteLine("You return to the dark room.");
                TakeSword();

                choice = ValidateInput("fight", "go back");

                if (choice == "fight")
                {
                    return FightDragon();
                }
        }
            else if (choice == "take treasure")
            {
                Console.Clear();
                Console.WriteLine("You decide to take the gleaming treasure and escape from the temple.");
                Console.WriteLine("As you pick up the treasure, the temple begins to collapse.");
                Console.WriteLine("You run as fast as you can and escape just in time, with the treasure in your possession!");
                Console.WriteLine("Congratulations, you have survived the adventure and obtained the treasure of Herat!");

                Console.WriteLine("\nAfter your adventure in Herat, you decide to return to the civilized world.");
                Console.WriteLine("Your treasure will bring you fame and wealth, and Herat will always remain in your memories.");
                Console.WriteLine("The adventure ends here. Thanks for playing!");

                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You decide to go back and leave the treasure untouched.");
            }

            return true;
        }
    }
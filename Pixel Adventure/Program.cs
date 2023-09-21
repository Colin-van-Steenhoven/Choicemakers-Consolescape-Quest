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

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i + 1);
        Console.Write("2. ");
        Console.ResetColor();
        Console.Write("Info");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write("Copyright\u00A9: ");
        Console.ResetColor();
        Console.Write("Colin van Steenhoven");

        Console.SetCursorPosition(Math.Max((screenWidth - 15) / 2, 0), logoPadding + i + 2);
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
                case "2":
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
            Console.WriteLine("\nDo you want to enter the temple? (yes/no)");

            string choice = ValidateInput("yes", "no");

            switch (choice)
            {
                case "yes":
                    Console.Clear();
                    Console.WriteLine("You enter the temple. The temple creaks, and strange sounds come from strange places.");
                    Console.WriteLine("You take a few steps and see a door to your left and an open room to your right (The room looks a bit dangerous).");
                    Console.WriteLine("\nDo you want to go left through the door, or do you want to go right into the open room? (left/right)");

                    choice = ValidateInput("left", "right");

                    switch (choice)
                    {
                        case "left":
                            Console.Clear();
                            Console.WriteLine("You go left and approach the door... It seems to be locked, but luckily you brought your lockpick set.");
                            Console.WriteLine("Do you want to try to pick the lock, or do you want to take a step back and reconsider your choice? (lockpick/go back)");

                            choice = ValidateInput("lockpick", "go back");

                            if (choice == "lockpick")
                            {
                                continueGame = PickLock();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You decide to go back and reconsider your choice.");
                            }
                            break;

                        case "right":
                            Console.Clear();
                            Console.WriteLine("You go right into the open room, where even stranger sounds are coming from.");
                            Console.WriteLine("Inside the room, you come face to face with a gigantic dragon!");
                            Console.WriteLine("You were not prepared, and the dragon defeats you. Game over!");
                            continueGame = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice. Choose again!");
                            break;
                    }
                    break;

                case "no":
                    Console.Clear();
                    Console.WriteLine("You decide not to enter the temple and leave.");
                    Console.WriteLine("The adventure ends here. Thanks for playing!");
                    continueGame = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Choose again!");
                    break;
            }
            if (choice == "take sword")
            {
                Console.Clear();
                Console.WriteLine("You have taken the sword and feel much more powerful.");
                Console.WriteLine("You return to the dark room and come face to face with the gigantic dragon.");
                Console.WriteLine("With the sword in your hands, you are determined to defeat the dragon!");
                Console.WriteLine("What do you want to do? (fight/go back)");

                choice = ValidateInput("fight", "go back");

                if (choice == "fight")
                {
                    Console.Clear();
                    Console.WriteLine("You engage in a battle with the dragon, and after an epic fight, you manage to defeat the dragon!");
                    Console.WriteLine("You have survived the adventure and defeated the dragon.");
                    Console.WriteLine("After the battle, you discover a secret door behind the dragon.");
                    Console.WriteLine("You open the door and find a large chest full of goods and diamonds!");
                    Console.WriteLine("Congratulations, you have won the game!");

                    Console.WriteLine("\nYou return to the civilized world with the large chest full of treasures and diamonds.");
                    Console.WriteLine("You become a legend, and Herat will always remain in your memories.");
                    Console.WriteLine("Thanks for playing!");
                    continueGame = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You decide to go back and reconsider your choice.");
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

        static bool PickLock()
        {
            Console.Clear();
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
}
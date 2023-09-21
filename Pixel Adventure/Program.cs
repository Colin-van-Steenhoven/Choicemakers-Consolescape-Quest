using System;

class Program
{
    static void Main(string[] args)
    {
        
        // ASCII art logo
        string logo = @"   
       ▄████▄  ██░ ██ ▒█████  ██▓▄████▄ ▓█████ ███▄ ▄███▓▄▄▄      ██ ▄█▓█████ ██▀███   ██████
      ▒██▀ ▀█ ▓██░ ██▒██▒  ██▓██▒██▀ ▀█ ▓█   ▀▓██▀█▀ ██▒████▄    ██▄█▒▓█   ▀▓██ ▒ ██▒██    ▒
     █    ▄▒██▀▀██▒██░  ██▒██▒▓█    ▄▒███  ▓██    ▓██▒██  ▀█▄ ▓███▄░▒███  ▓██ ░▄█ ░ ▓██▄
      ▒▓▓▄ ▄██░▓█ ░██▒██   ██░██▒▓▓▄ ▄██▒▓█  ▄▒██    ▒██░██▄▄▄▄██▓██ █▄▒▓█  ▄▒██▀▀█▄   ▒   ██▒
      ▒ ▓███▀ ░▓█▒░██░ ████▓▒░██▒ ▓███▀ ░▒████▒██▒   ░██▒▓█   ▓██▒██▒ █░▒████░██▓ ▒██▒██████▒▒
      ░ ░▒ ▒  ░▒ ░░▒░░ ▒░▒░▒░░▓ ░ ░▒ ▒  ░░ ▒░ ░ ▒░   ░  ░▒▒   ▓▒█▒ ▒▒ ▓░░ ▒░ ░ ▒▓ ░▒▓▒ ▒▓▒ ▒ ░
        ░  ▒   ▒ ░▒░ ░ ░ ▒ ▒░ ▒ ░ ░  ▒   ░ ░  ░  ░      ░ ▒   ▒▒ ░ ░▒ ▒░░ ░  ░ ░▒ ░ ▒░ ░▒  ░ ░
      ░        ░  ░░ ░ ░ ░ ▒  ▒ ░          ░  ░      ░    ░   ▒  ░ ░░ ░   ░    ░░   ░░  ░  ░";

        

        // Calculate padding for centering
        int screenWidth = Console.WindowWidth;
        int screenHeight = Console.WindowHeight;
        int logoPadding = Math.Max((screenHeight - logo.Split('\n').Length) / 2, 0);

        // Set the foreground color to green
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var i = 0;
        // Print the logo with padding
        foreach (string line in logo.Split('\n'))
        {
            Console.SetCursorPosition(Math.Max((screenWidth - line.Length) / 2, 0), i);
            Console.WriteLine(line);
            i++;
        }
        // Reset the console color to the default
        Console.ResetColor();

        // Set the foreground color for menu options
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        // Aangepaste positie voor het menu
        logoPadding = 5; // Verklein deze waarde om het menu omhoog te verplaatsen

        // Menuopties
        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i);
        Console.Write("1. ");
        Console.ResetColor();
        Console.Write("Play");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(Math.Max((screenWidth - 7) / 2, 0), logoPadding + i + 1);
        Console.Write("2. ");
        Console.ResetColor();
        Console.Write("Info");

        // Print the copyright-regel left bottom in the console
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write("Copyright\u00A9: ");
        Console.ResetColor();
        Console.Write("Colin van Steenhoven");

        Console.SetCursorPosition(Math.Max((screenWidth - 15) / 2, 0), logoPadding + i + 2);
        Console.Write("Enter your choice: ");
        string? choice1 = Console.ReadLine();

        // Reset the console color to the default
        Console.ResetColor();

        
        

        if (choice1 != null)
        {
            switch (choice1)
            {
                case "1":
                    Console.WriteLine("Starting the game...");
                    Console.Clear();
                    // Add your game logic here for the Main game
                    // You can now use the 'asciiArt' variable wherever you want in your game.

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

                    // Wait for Enter to be pressed
                    Console.ReadLine();

                    // Clear the console screen
                    Console.Clear();

                    // Print the ASCII art to the console
                    Console.WriteLine(asciiArt);

                    bool continueGame = true;

                    while (continueGame)
                    {
                        Console.WriteLine("You came from a far travel, you find youreself in a place called Herat. \nHerat is a Jungle like place with many secrets to be discovered, lets begin! \nPress enter to continue...");
                        Console.ReadLine();
                        
                        Console.Clear();
                        Console.WriteLine("After entering Herat you come across a jungle temple... It looks interesting.");
                        Console.WriteLine("\nDo you want to anter the temple? (yes/no)");
                        

                        string choice = Console.ReadLine().ToLower();

                        switch (choice)
                        {
                            case "yes":
                                Console.Clear();
                                Console.WriteLine("You walk in the temple, the temple creeks and has strange noises coming from strange places. You walk a few steps and see a door on you're left and a open room on you're right (The room looks a little dangerous)");
                                Console.WriteLine("\nDo you want to go left in the door, or do you want to go right in the open room? (left/right)");

                                choice = Console.ReadLine().ToLower();


                                switch (choice)
                                {
                                    case "left":
                                        Console.Clear();
                                        Console.WriteLine("You go left, you approach the door... It seems locked but fortunately enough u brought you're lockpick set.");
                                        Console.WriteLine("\nDo you want to pick the lock? or do you want to take a step back and reconsider you're choice? (pick lock/go back)");
                                        break;
                                    case "right":
                                        Console.Clear();
                                        Console.WriteLine("You go right right to the open room, there are even more strange noises coming from this side of the room. You enter the room and encounter a dragon.");
                                        Console.WriteLine("\nYou were not prepared, and the dragon defeats you. Game over!");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice. Choose again!");
                                        break;
                                }
                                continueGame = false;
                                break;
                            case "no":
                                Console.WriteLine("You decide not to enter the temple and leave.");
                                Console.WriteLine("The adventure ends here. Thanks for playing!");
                                continueGame = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Choose again!");
                                break;
                        }
                    }

                    break;

                case "2":
                    Console.WriteLine("Displaying game information...");
                    // Add code to display game information for the "Info" option
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }
    }
}

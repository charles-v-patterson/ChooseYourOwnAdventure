using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\r\n");

            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToUpper();

            if (noiseChoice == "NO")
            {
                Console.Write("Not much of an adventure if we don't leave our room!\r\n");
                Console.Write("THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.Write("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?\r\n");

                Console.Write("Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine().ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.Write("A voice behind the door speaks. It says, \"Answer this riddle: \"\r\n");
                    Console.Write("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"\r\n");
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.Write("The door opens and NOTHING is there.\r\n");
                        Console.Write("You turn off the light and run back to your room and lock the door.\r\n");
                        Console.Write("THE END.");
                    }
                    else
                    {
                        Console.Write("You answered incorrectly. The door doesn't open.\r\n");
                        Console.Write("THE END");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.Write("The door is locked! See if one of your three keys will open it.\r\n");
                    Console.Write("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine().ToUpper();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                            Console.WriteLine("The door opens and NOTHING is there.");
                            Console.WriteLine("Strange...");
                            Console.WriteLine("THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                            Console.WriteLine("The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                    }
                }
            }
        }
    }
}






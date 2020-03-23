using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Defenders =
                {"Smoke",
                 "Mute",
                 "Castle",
                 "Pulse",
                 "Doc",
                 "Rook",
                 "Kapkan",
                 "Tachanka",
                 "Jäger",
                 "Bandit",
                 "Frost",
                 "Valkyrie",
                 "Caveira",
                 "Echo",
                 "Mira",
                 "Lesion",
                 "Ela",
                 "Vigil",
                 "Maestro",
                 "Alibi",
                 "Clash",
                 "Kaid",
                 "Mozzy",
                 "Warden",
                 "Goyo",
                 "Wamai",
                 "Oryx"

            };

            string[] Attackers =
                {
                 "Sledge",
                 "Thatcher",
                 "Ash",
                 "Thermite",
                 "Twitch",
                 "Montagne",
                 "Glaz",
                 "Fuze",
                 "Blitz",
                 "IQ",
                 "Buck",
                 "Blackbeard",
                 "Capitão",
                 "Hibana",
                 "Jackal",
                 "Ying",
                 "Zofia",
                 "Dokkaebi",
                 "Lion",
                 "Finka",
                 "Maverick",
                 "Nomad",
                 "Gridlock",
                 "NØkk",
                 "Amaru <3",
                 "Kali",
                 "Iana"
            };

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            Console.WriteLine("Welcome to Rainbow operator picker!");

            Console.WriteLine("Defend or Attack?");

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Defend or Attack?");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Defend");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Attack();
                    return true;
                case "2":
                    Defend();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void Attack()
        {
            Console.Clear();
            Console.WriteLine("You have chosen Attackers:");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void Defend()
        {
            Console.Clear();
            Console.WriteLine("You have chosen Defenders:");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
    


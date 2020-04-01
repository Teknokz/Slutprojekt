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

            //Här säger jag åt boolen att visa main menu tills annat sägs
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        //Denna metod styr menyn 

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Defend or Attack?");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Defend");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            //Denna delen gör att man kan hoppa fram och tillbaka mellan de olika delarna i menyn. Jag har valt switch då det gör det väldigt simpelt att hoppa fram och tillbaka mellan respektive metod.

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

        //Denna metod styr Attack sektionen av huvudmenyn

        private static void Attack()
        {
            Console.Clear();
            Console.WriteLine("You have chosen Attackers:");

            string attackResult = attackOperators();

            Console.WriteLine("You got " + attackResult);

            Console.WriteLine("Press Any key to retun to main menú");

            Console.ReadLine();
        }

        //Denna metod styr Defend sektionen av huvudmenyn

        private static void Defend()
        {
            Console.Clear();
            Console.WriteLine("You have chosen Defenders:");

            string defendResult = defendOperators();

            Console.WriteLine("You got " + defendResult);

            Console.WriteLine("Press Any key to retun to main menú");

            Console.ReadLine();
        }     

        //Metoden som ansvar för att lagra operatorindexen och randomiza svaret för Attackers

        private static string attackOperators()
        {

            //index för att Attackers

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

            Random generator = new Random();

            int value = generator.Next(0, 27);

            string i = Attackers[value];

            return i;

        }

        //Metoden som ansvar för att lagra operatorindexen och randomiza svaret för Defenders

        private static string defendOperators()
        {

            //index för att Defenders

            string[] Defenders =
                {
                "Smoke",
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

            

            Random generator = new Random();

            int value = generator.Next(0, 27);

            string i = Defenders[value];

            return i;

        }
    }
}
    


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
            string[] Map =
                {"Defender{}",
                 "Attacker{}"};
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

            Console.WriteLine("Welcome to Rainbow operator picker!");

            Console.WriteLine("Defend or Attack?");

            int menuPosition = 0;
            //
            while(1 == 1)
            {
                if(menuPosition == 0)
                {
                    Position();

                }
                else
                {

                }
            }




            Console.ReadLine();
        }
       private static int Position()
        {
            ConsoleKeyInfo ValidKeys = Console.ReadKey(true);

            int i = 0;
            return i;
        } 
    }
}

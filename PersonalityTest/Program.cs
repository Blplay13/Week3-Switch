using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada tema lemmikvarv;
            //kui kasutaja sisestab "punane", siis konsool kivab "Oled romantiline"
            //kui kasutaja sisestab "sinine", siis konsool kuvab "Oled tookas"
            //kui kasutaja sisestab "roheline", siis konsool kuvab "Oled looduse sober"
            //kui kasutaja sisestab muud, siis konsool kuvab "oled {userColor} ukssarvik";

            Console.WriteLine("Sisesta oma lemmikvarv:");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline!");

            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled tookas!");

            }   
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sober!");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ukssarvik!");
            }

            Console.WriteLine("Kena paeva!");
        }
    }
}

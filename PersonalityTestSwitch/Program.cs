using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada tema lemmikvarv;
            //kui kasutaja sisestab "punane", siis konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine", siis konsool kuvab "oled tookas"
            //kui kasutaja sisestab "roheline", siis konsool kuvab "Oled looduse sober"
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "oled {userColor} ukssarvik;

            Console.WriteLine("Sisesta oma lemmikvarv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case"punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled tookas!");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sober!");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ukassarvik");
                    break;

            }

            Console.WriteLine("Kena paeva!");
        }

    }
}

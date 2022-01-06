using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {//programm kusib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suureparane",
            //"B", konsool kuvab "vaga hea";
            //"C", konsool kuvab "hea";
            //"D", konsool kuvab "rahuldav";
            //"E", konsool kuvab "kasin";
            //"F", konsool kvab "puudulik";
            //kui kasutaja sisestab dimagi muud, siis kuvab "vale vaartus";
            //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suureparane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Vaga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine("Vale vaartus");
            }
        }
    }
}

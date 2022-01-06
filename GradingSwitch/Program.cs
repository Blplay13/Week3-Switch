using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suureparane",
            //"B", konsool kuvab "vaga hea";
            //"C", konsool kuvab "hea";
            //"D", konsool kuvab "rahuldav";
            //"E", konsool kuvab "kasin";
            //"F", konsool kvab "puudulik";
            //kui kasutaja sisestab dimagi muud, siis kuvab "vale vaartus";
            //kasutame Switch

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {

                case 'A':
                    Console.WriteLine("Suureparane!");
                    break;
                case 'B':
                    Console.WriteLine("Vaga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                default:
                    Console.WriteLine("Vale vaartus");
                    break;
            }
            Console.WriteLine("Kena paeva!");
            }

        }

    }


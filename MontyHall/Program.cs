using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool[] buste = new bool[3];

            int vittorieConcorrente = 0;
            int vittorieMH = 0;

            for (int i = 0; i < 1000000; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buste[j] = false;
                }

                buste[random.Next(3)] = true;

                // La busta del concorrente è sempre la prima (la busta 0)

                int bustaMH;
                if (buste[1] == true)
                    bustaMH = 2;
                else
                    bustaMH = 1;

                // MH: Vuoi cambiare le buste?
                // Concorrente: SI!!!

                int bustaConcorrente;
                if (bustaMH == 1)
                    bustaConcorrente = 2;
                else //if (bustaMH == 2)
                    bustaConcorrente = 1;

                // Chi ha vinto?

                if (buste[bustaConcorrente] == true)
                    vittorieConcorrente++;
                else
                    vittorieMH++;
            }


            Console.WriteLine("MH: {0} Concorrente {1}", vittorieMH, vittorieConcorrente);

            Console.ReadLine();
        }
    }
}

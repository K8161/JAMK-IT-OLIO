using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Lotto
    {
        
        public static void lottokone()
        {
            int[] lottorivi = new int[7]; /*Alkiot 0-6*/
            int x, i, j, apu, maara, rivinmr = 0;
            bool arvottu = false;
            Random rand = new Random();
            //  srand(time(NULL)); /*alustetaan satunnaislukugeneraattori */

            Console.WriteLine("Montako riviä arvotaan?");
            maara = Convert.ToInt32(Console.ReadLine());

            for (apu = 0; maara > 0; maara--)
            {

                // Ensin arvotaan
                for (i = 0; i < 7; i++)
                {
                    x = rand.Next(1, 40);

                    // PITÄÄ tarkistaa, että kelpaako arvottu numero
                    // Käydään aiemmin arvotut numerot läpi:
                    for (j = 0; j < i; j++)
                    {
                        if (lottorivi[j] == x)
                        {
                            arvottu = true;
                        }
                    }

                    if (arvottu)
                    {
                        // PITÄÄ arpoa uudestaan
                        x = rand.Next(1, 40);
                        i--;
                        arvottu = false;
                    }
                    else
                    { // KELPAA:
                        lottorivi[i] = x;
                    }
                }

                for (i = 6; i >= 1; i--)
                {

                    for (j = 0; j <= i - 1; j++)
                    {
                        // Vertaa kahta peräkkäistä, vaihda isompi oikealle
                        if (lottorivi[j] > lottorivi[j + 1])
                        {
                            apu = lottorivi[j];
                            lottorivi[j] = lottorivi[j + 1];
                            lottorivi[j + 1] = apu;

                        }
                    }
                }

                rivinmr++;

                //Sitten tulostetaan:
                Console.WriteLine(rivinmr + ". Lottorivi \n");
                for (i = 0; i < 7; i++)
                {
                    if (i <= 5)
                        //   cout << lottorivi[i] << endl;
                        Console.Write(lottorivi[i] + ", ");

                    else
                        Console.Write(lottorivi[i] + "\n\n");
                }
            }
        }
    }
}




using System;
using static System.Net.WebRequestMethods;

namespace uppgift_4._8
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng bokstäver");
            string lång = Console.ReadLine();
            Console.WriteLine("Skriv in en sträng med exact två bokstäver");
            string kort = Console.ReadLine();

            string matchade = "";

            for (int i = 0; i < kort.Length; i++)
            {
                char matcha = kort[i];

                for (int j = 0; j < lång.Length; j++)
                {
                    char leta = lång[j];
                    if(matcha == leta)
                    {
                        if (matcha == leta)
                        {
                            matchade = matchade + matcha;
                            break;
                        }
                    }
                }
                if (matchade == kort)
                {
                    Console.WriteLine("Bokstäverna matchar");
                }
                else
                {
                    Console.WriteLine("Alla bokstäver matchar inte");
                }
            }   
        }
    }
}
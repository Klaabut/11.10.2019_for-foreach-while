using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int number;
              Console.WriteLine("Sisesta number:");
              number = int.Parse(Console.ReadLine());
           for(int i = 0; i <= 100; i++)
              {
                  Console.WriteLine($"{number} x {i} = {number * i}");
              }*/

            /*string name;
            Console.WriteLine("Write ur name");
            name = Console.ReadLine();
            int counter = 0;

            foreach(char letter in name)
            {
                counter++;
            }
            Console.WriteLine($"Your name is {counter} letters long.");*/



            string word;
            Console.WriteLine("Sisetage sõna:");
            word = Console.ReadLine();
            //bool letterFound = false;
            /* foreach(char letter in word)
             {
                 Console.WriteLine(letter);
                 if(letter == 'a')
                 {
                     letterFound = true;
                     Console.WriteLine("Letter A found!");
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Not Found");
                 }
             }*/

           /* int atotal = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    atotal++;
                }
                else
                {
                    continue;
                }
            }
            if (atotal > 1)
            {
                Console.WriteLine($"There are {atotal} a's in that word.");

            }
            else
            {
                Console.WriteLine($"There is {atotal} a in that word");
            }*/


            //Task 3

            /*foreach (char letter in word)
            {
                Console.Write(letter);
                Console.Write(" ");
            }*/

            /*for (int i = 0; i < word.Length ; i++ )
            {
                if(i == word.Length - 1)
                {
                    Console.Write($"{word[i]}");
                }
                else
                {
                Console.Write($"{word[i]}*");
                }*/

            


               
                
            }

            Console.ReadLine();
        }

    }
}

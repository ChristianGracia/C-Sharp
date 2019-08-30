﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word for the vowels to be counter");
            var word = Console.ReadLine().ToLower();
      
            var letterArray = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                letterArray[i] = word.Substring(i,1);

            }

            var vowelCounter = 0;
    
            for (var i = 0; i < letterArray.Length-1; i++)
            {
                switch (letterArray[i])
                {
                    case "a":
                        vowelCounter++;
                        break;
                    case "e":
                        vowelCounter++;
                        break;
                    case "i":
                        vowelCounter++;
                        break;
                    case "o":
                        vowelCounter++;
                        break;
                    case "u":
                        vowelCounter++;
                        break;
                    default:
                        break;
                }
           
            }
            Console.WriteLine("vowel counter: " + vowelCounter);
        }

    }
}

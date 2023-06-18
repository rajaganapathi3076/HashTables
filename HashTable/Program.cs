using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Problem UC3");
            string sentence = "“Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations”";
            string wordToRemove = "avoidable";
            string[] words = sentence.Split();

            var hashTable = new HashTable<string, int>();


            //foreach (var word in words)
            //{
            //    if (!string.IsNullOrEmpty(word))
            //    {
            //        hashTable.Insert(word, true);
            //    }
            //}

            //hashTable.Remove(wordToRemove);

            //foreach (var word in words)
            //{
            //    if (!string.IsNullOrEmpty(word) && hashTable.GetFrequency(word) != null)
            //    {
            //        Console.Write($"{word} ");
            //    }

            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (hashTable.GetFrequency(word) == 0)
                    {
                        hashTable.Insert(word, 1);
                    }
                    else
                    {
                        int frequency = hashTable.GetFrequency(word);
                        hashTable.Insert(word, frequency + 1);
                    }
                }
            }
            hashTable.Remove(wordToRemove);
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    int frequency = hashTable.GetFrequency(word);
                    Console.WriteLine($"The frequency of '{word}' is {frequency}");
                }

                

        }   }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Problem UC1");
            string sentence = "To be or not to be ";
            string[] words = sentence.Split();

            var hashTable = new HashTable<string, int>();

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

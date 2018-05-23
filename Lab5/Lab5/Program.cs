using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("slovar.txt", Encoding.Default);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] split;
            while (!sr.EndOfStream)
            {
                split = sr.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (!dictionary.ContainsKey(split[0]))
                {
                    dictionary.Add(split[0], split[1]);
                }
            }
            sr.Close();
            sr.Dispose();
            while (true)
            {
                string word = Console.ReadLine();
                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine("Перевод: " +dictionary[word]);
                }
                else
                {
                    Console.WriteLine("Не найдено");
                }
            }
        }
    }
}
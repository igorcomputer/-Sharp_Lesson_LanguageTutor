using System;
using System.Collections;

namespace LanguageTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var tutor = new Tutor();
            tutor.AddWord("hello", "привет");
            tutor.AddWord("dog", "собака");
            tutor.AddWord("cat", "кошка");
            tutor.AddWord("byke", "велосипед");

            if (tutor.CheckWord("dog", "собака"))
            {
                Console.WriteLine("Правильно!");
            } 
            else
            {
                Console.WriteLine("Не правильно!");
            }

        }
    }
}

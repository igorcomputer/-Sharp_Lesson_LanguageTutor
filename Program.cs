﻿using System;
using System.Collections;

namespace LanguageTutor
{
    class Program
    {
        static void Main(string[] args)
        {

            var tutor = new Tutor();
            //tutor.AddWord("hello", "привет");
            //tutor.AddWord("dog", "собака");
            //tutor.AddWord("cat", "кошка");
            //tutor.AddWord("byke", "велосипед");

            while (true)
            {
                var word = tutor.GetRandomEngWord();
                Console.WriteLine($"Как переводится слово: {word}?");

                var userAnswer = Console.ReadLine();
                if (tutor.CheckWord(word, userAnswer))
                    Console.WriteLine("Правильно!");
                else
                {
                    var correctAnswer = tutor.Translate(word);
                    Console.WriteLine($"Неверно. Правильный ответ: {correctAnswer}");
                }
            }

        }
    }
}

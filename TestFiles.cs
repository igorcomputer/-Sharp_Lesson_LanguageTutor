using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LanguageTutor
{
    class TestFiles
    {
        public void Test()
        {
            string path = "text.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Строка 1");
                sw.WriteLine("Строка 2");
            }

            if (File.Exists(path))
            {
                Console.WriteLine("Файл найден");
            }

            Console.WriteLine("==== StreamReader(path) ======");

            string line = "";
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("==== File.ReadLines(path) ======");

            var lines = File.ReadLines(path);
            foreach (var lineItem in lines)
            {
                Console.WriteLine(lineItem);
            }

            Console.WriteLine("==== File.ReadAllText(path)) ======");

            var text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
    }
}

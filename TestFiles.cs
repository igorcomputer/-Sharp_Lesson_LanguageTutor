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

        public List<int> GetArrayFromFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                var numString = content.Split(' ');
                List<int> nums = new List<int>();

                for (int i = 0; i < numString.Length; i++)
                {
                    int num;
                    if (Int32.TryParse(numString[i], out num))
                        nums.Add(num);
                }
                return nums;
            } catch (Exception ex)
            {
                Console.WriteLine($"Не удалось прочитать содержимое файла {path}");
                return new List<int>();
            }
        }
    }
}

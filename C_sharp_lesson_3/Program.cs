using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace C_sharp_lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);           
            //var path = Environment.CurrentDirectory;

            // Задание 3
            /* string path;
             try
             {
                 path = args[0];
                 DirectoryInfo myDirInfo = new DirectoryInfo(path);
                 foreach (var item in myDirInfo.EnumerateDirectories())
                 {
                     Console.WriteLine($"Каталог {item}");
                 }
                 foreach (var item in myDirInfo.EnumerateFiles())
                 {
                     Console.WriteLine($"Файл {item} имеет размер {item.Length} байт, был изменён {item.LastWriteTime} ");
                 }
             }
             catch (Exception)
             {
                 Console.WriteLine("Нет аргументов командной строки\nФайлы текущей папки:");
                 path = Environment.CurrentDirectory;

                 DirectoryInfo myDirInfo = new DirectoryInfo(path);
                 foreach (var item in myDirInfo.EnumerateDirectories())
                 {
                     Console.WriteLine($"Каталог {item}");
                 }
                 foreach (var item in myDirInfo.EnumerateFiles())
                 {
                     Console.WriteLine($"Файл {item} имеет размер {item.Length} байт, был изменён {item.LastWriteTime} ");
                     //var lastModified = myDirInfo.LastWriteTime;
                     //TimeSpan delta = item.LastAccessTime - lastModified;                    
                     //int year = int.Parse(lastModified.ToString("yyyy"));
                 }
             }
                    */

            /* for (int i = (int)'0'; i <= (int)'9'; i++)
             {
                 Console.WriteLine(((char)i).ToString() + " имеет код " + i);
             }*/

            ///////////////////////////////////////////

            // Регулярные выражения
            string input = "25 * 45 =\r\n12 - 5 =";
            var regexpLeft = new Regex(@"\d+\s*(\+|\-|\*|\/)");
            var regexpRight = new Regex(@"(\+|\-|\*|\/)\s*\d+");
            var regNumber = new Regex(@"\d+");
            var regexpOperation = new Regex(@"(\+|\-|\*|\/)");

            MatchCollection matchesLeft = regexpLeft.Matches(input);
            MatchCollection matchesRight = regexpRight.Matches(input);
            foreach (Match match in matchesLeft)
            {
                Console.WriteLine("Левый операнд и операция :" + match.ToString());
                MatchCollection numberLeft = regNumber.Matches(match.ToString());
                Console.WriteLine("Левый операнд : " + numberLeft[0]);
            }
            foreach (Match match in matchesRight)
            {
                Console.WriteLine("Правый операнд и операция :" + match.ToString());
                MatchCollection numberRight = regNumber.Matches(match.ToString());
                Console.WriteLine("Правый операнд : "+ numberRight[0]);
            }

            Console.ReadKey();
        }
    }
}

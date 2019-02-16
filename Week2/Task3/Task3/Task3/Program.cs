using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void space(int level)//создаем функцию, которая создает отступы в иерархии папок
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }
        static void hierarchy(DirectoryInfo directory, int level)
        {

            FileInfo[] files = directory.GetFiles();//сохраняем информацию о файлах в папке
            DirectoryInfo[] directories = directory.GetDirectories();//сохраняем информацию о папках в папке
            foreach (FileInfo file in files)
            {
                space(level);//отправляем уровнь иерархии в функцию для отступа
                Console.WriteLine(file.Name);//вывод названия файла
            }
            foreach (DirectoryInfo dir in directories)
            {
                space(level);//отправляем уровень иерархии в функцию для отступа
                Console.WriteLine(dir.Name);//вывод названия файла
                hierarchy(dir, level + 1);//рекурсивно обращаемся к той же функции, увеличивая уровень иерархии
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\THE_MAULER\Desktop\PP2");//сохраняем информацию о папке
            hierarchy(directory, 0);//отправляем информацию о папке в функцию
            Console.ReadKey();
        }
    }
}

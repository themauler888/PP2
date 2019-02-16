using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student//создаем класс студентов
    {
        public string name;//добавляем переменную типа string - имя студента
        public string id;//добавляем переменную типа string - id студента
        public int year;//добавляем переменную типа integer - год обучения студента

        public Student(string n, string i)//создаем конструктор с двумя параметрами
        {
            name = n;//переменной name присваиваем n, которую принимает конструктор
            id = i;//переменной id присваиваем i, которую принимает конструктор
        }
        public void Data()//создаем метод для вывода информации о студентах из класса Student
        {
            Console.WriteLine("Name of student: " + name + "\n" + "ID of student: " + id);
        }
        public int NextYear(int y)//создаем функцию, которая возвращает год обучения, увеличенный на 1
        {
            year = y;
            return year + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");
            string name = Console.ReadLine();//ввод имени студента
            Console.WriteLine("Write ID: ");
            string id = Console.ReadLine();//ввод id студента
            Console.WriteLine("Write year of study: ");
            int year = int.Parse(Console.ReadLine());//ввод года обучения студента

            Student s = new Student(name, id);//добавляем новую запись в класс students
            s.Data();//вызываем метод для вывода имени и id студента
            Console.WriteLine("Next year of study: " + s.NextYear(year));//выводим следущий год обучения, обращаясь к функции
        }
    }
}

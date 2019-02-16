using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static public bool Prime(int a) //создаем функцию,которая принимает одно целое число и возвращает true,если число простое,и false,если число составное
        {
            if (a==1)//единица не простое число
            {
                return false;
            }
            for(int i=2;i<a;i++)//пробегаемся по числам от 2 до a
            {
                if(a%i == 0)//если число а делится на какое-то число не равное 1 и самому себе, значит оно составное
                {
                    return false;
                }
            }
            return true;//если число не имеет делителей, кроме себя и 1, значит оно простое
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());//создаем переменную типа integer, которая задает размер массива
            int counter = 0;//создаем счётчик простых чисел, который изначально равен нулю
            int[] arr = new int[number];//создаем массив целых чисел
            for(int i=0;i<number;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());//заполняем массив целыми числами
                if (Prime(arr[i]) == true)
                {
                    counter++;//считаем количество простых чисел в массиве
                }

            }
            Console.WriteLine(counter);//выводим число,количество простых чисел в массиве
            for (int i=0;i<number;i++)
            {
                if (Prime(arr[i])==true)
                {
                    Console.Write(arr[i] + " ");//выводим простые числа
                }
            }
        }
    }
}

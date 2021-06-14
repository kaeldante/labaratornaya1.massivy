/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 14.06.2021
 * Время: 18:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Linq;

namespace pr1
{
	class Program
	{
		 static void Main(string[] args)
		{
		 	Console.WriteLine("Лабораторная работа 1.Вариант 5 - Выводит индексы четных элементов");
		 	Console.WriteLine("===============================");
		 	
		 	
			Console.Write("РАЗМЕР МАССИВА= " );
                var len = int.Parse(Console.ReadLine());
                var array = new int[len];
                 
                for (int i = 0; i < array.Length; i++)
                	
                {
                    Console.Write("Элемент ("+i+") = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("===============================");
                Console.WriteLine("ИНДЕКСЫ ЧЕТНЫХ ЭЛЕМЕНТОВ");
                for (int i = 0; i < array.Length; i++)
                	
                {
                	
                	if (array[i] % 2==0)
                		
                		Console.WriteLine(i);
                	
                }
                Console.WriteLine("===============================");
                Console.WriteLine("Для продолжения нажмите любую клавишу....");
                Console.ReadKey(true);
		
		}
	}
}
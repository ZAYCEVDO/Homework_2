using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Task_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину стороны треугольника:");
			int katet = int.Parse(Console.ReadLine());
			int countSpaces = katet;
			string str = "";

			Console.WriteLine();

			countSpaces = katet - 1; //Кол-во отступов слева от левой звезды
			int insideSpaces = -1;  //Кол-во пробелов между правой и левой звездами
			for(int i = 0; i < katet; i++)
			{
				if(i == 0)
				{
					str = new string(' ', countSpaces) + ("*");  //Вывод самой верхней звезды
					Console.WriteLine(str);
				}
				if (i > 0 && i < katet - 1)
				{
					countSpaces--;
					insideSpaces += 2;
					str = new string(' ', countSpaces) + ("*") + new string(' ', insideSpaces) + ("*");  //Вывод боковых звезд
					Console.WriteLine(str);
				}
				if (i == katet - 1 )
				{
					str = "";
					for(int j = 0; j < katet; j++)
					{
						str += "* ";             //Вывод нижней стороны
					}
					Console.WriteLine(str);
				}
			}

		}
	}
}

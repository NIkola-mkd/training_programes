﻿// Таким образом вы подключаете пространство имен System к вашему кодовому файлу 
// (не к всему проекту! Это не Reference!)
using System;
using System.Globalization;

//Таким образом вы определяете свое пространство имен.
namespace Project_1
{
	// Таким образом определяется класс.
	class Program
	{
		/*
		 * static - некое волшебное слово, смысл которого будет ясен позднее.
		 * void Main() определяет метод.
		 * Из-за своего названия Main является точкой входа — это метод, 
		 * который будет запущен при выполнении программы.
		 */
		 
		static void Main(string[] args)
		{
			// Этот код выводит на экран строку
			// Console — это класс, так же как Program, но из пространства имен System.
			Console.WriteLine("Hello, world!");
			// Обратите внимание, регистр символов имеет значение!
			// Console.writeline("Hello, world"); // это не скомпилируется.

			// Как и в любом языке программирования, нужно строго соблюдать синтаксис.
			// Например, каждую инструкцию нужно заканчивать точкой с запятой.
			// Сonsole.WriteLine("Hello, world") // это не скомпилируется.

			// Попробуйте совершить несколько ошибок и посмотреть на сообщения об ошибках


			//Переменная — это именованная область памяти.
			//
			//Тип переменной — это формат области памяти, определяющий множество возможных значений
			// переменной и множество допустимых операций над ней.

			int integerNumber;
			// так объявляется переменная: тип (int), затем имя (integerNumber)

			// так осуществляется присваивание
			integerNumber = 10;

			// double - основной тип чисел с плавающей точкой.
			// Можно совмещать объявление и присваивание.
			double realNumber = 12.34;

			// float - тип меньшей точности.
			// Суффикс f говорит, что 1.234 - константа типа float, а не double.
			// Используются в библиотеках работы с графикой в Windows.
			float floatNumber = 1.234f;

			//long (большие целые числа). Часто используется для подсчета миллисекунд. 
			// L - суффикс констант такого типа, чтобы не перепутать их с int.
			long longIntegerNumber = 3000000000000L;

			// Есть и другие типы данных: short, decimal, и т.д.
			// В основном, для чисел вы будете пользоваться int и double, иногда - long и float


			// Конверсия типов (cast) - это преобразование одного типа переменной в другой 

			//int integerNumber = 45;
			double doubleNumber = 34.56;

			doubleNumber = integerNumber;
			// Это неявная конверсия типов: присвоение переменной одного типа 
			// значения переменной другого типа без дополнительных усилий. 
			// Она возможна, когда не происходит потери информации

			integerNumber = (int)doubleNumber;
			// Это явная конверсия типов. В случае, когда конверсия ведет к потере информации
			// (в данном случае - дробной части), необходимо явно обозначать свои намерения
			// по конверсии.

			integerNumber = (int)Math.Round(34.67);
			// Округление лучше всего делать не конверсией, а функцией Round. 
			// Кстати, Math - "математическая библиотека" C# - имеет множество других
			// полезных методов. 

			long longInteger = 4000000000;
			integerNumber = (int)longInteger;
			// При такой конверсии происходит ошибка переполнения, которая, однако, остается
			// незамеченной для компилятора и среды разработки

			// Таким образом можно отловить эти ошибки явно
			/*checked
			{
				integerNumber = (int)longInteger;
			}
			*/
			//Строки - это последовательности символов
			string myString = "Hello, world!";

			// + — это операция "приписывания" одной строки к другой:
			string s = "Hello" + " " + "world";

			// Можно обращаться к отдельным символам
			char c = myString[1]; //'e' — нумерация символов с нуля.
			char myChar = 'e'; // одинарные кавычки используются для символов. Двойные — для строк.

			//У строк есть собственные методы и переменные (правильно называть это свойствами),
			//которые позволяют узнать информацию о строке 
			Console.WriteLine(myString.Length);

			myString = myString.Substring(0, 5);
			Console.WriteLine(myString);

			string strangeSymbols = "© 2014 Σγμβόλσ";

			//Тип string может иметь особое значение - null.
			//Это не пустая строка, а отсутствие всякой строки.
			myString = null;

			//Интересно, что тип int такого значения иметь не может.
			//int a=null;

			int number = int.Parse("42"); //Из строки в число
			string numString = 42.ToString(); // Из числа в строку
			//double number2 = double.Parse("34.42"); // Зависит от настроек операционной системы

			//Следующий вызов не зависит от настроек и всегда ожидает точку в качестве разделителя:
			double number2 = double.Parse("34.42", CultureInfo.InvariantCulture);

			//Следующий вызов не зависит от настроек и всегда использует точку в качестве разделителя:
			string invariantNumber2 = number2.ToString(CultureInfo.InvariantCulture);
			Console.WriteLine(invariantNumber2); //34.42

			/*
			int a = 23;
			int b = 45;
			double angle = 1.4;

			// Математические операции записываются естественным образом
			int c = (a + b) / 2;

			//Класс Math содержит полезные методы и константы
			Console.WriteLine(Math.Sin(angle));

			var d = a - b;
			/* часто понятно, какого типа должна быть переменная. В этом случае можно писать var
			 * Компилятор самостоятельно догадается, что именно вы имели в виду
			 */
			/*
		   // это целое число
		   var e = a / 2;
		   // это число с плавающей точкой
		   var f = a / 2.0;

		   c = b = a;
		   /* Как это работает? b=a - оператор присвоения, но он имеет собственное 
			* возвращаемое значение (равное a)
			* Поэтому c = b = a выполняется так:
			* - b присваивается a
			* - c присваивается результату b=a, который также равен a
			* В итоге все три переменные будут равны
			*/
			/*
		   a -= 4;
		   // То же самое, что a=a-4, аналогично с другими операциями.

		   a++;
		   //Оператор инкремента
		   //То же самое, что a=a+1

		   a--;
		   //Оператор декремента
		   //То же самое, что a=a-1

		   ++a;
		   //То же самое, что a=a+1, но с одним отличием:

		   a = 5;
		   Console.WriteLine(a++);
		   // выведет 5

		   a = 5;
		   Console.WriteLine(++a);
		   // выведет 6
		   */
		}
	}
}

/*
class Program
{

	// Это метод, возвращающий значение типа int, принимающий два аргумента типа double.
	// Его можно называть функцией, но это название не очень распространено.
	// Сигнатура метода - это совокупность имени метода и последовательности типов аргументов
	static int DivideAndRound(double a, double b)
	{
		// return указывает, какое значение будет возвращено
		return (int)Math.Round(a / b);
	}

	// Это метод, не возвращающий значения. Вместо типа возвращаемого значения стоит void
	static void WriteNumber(int number)
	{
		Console.WriteLine(number);

		// return указывается без значения, и его следует опускать, когда это возможно
		return;
	}

	static void WriteNumber(int number, int anotherNumber)
	{
		Console.WriteLine(number);
		Console.WriteLine(anotherNumber);
	}

	static void Main()
	{
		WriteNumber(DivideAndRound(10.5, 2.1));
	}
}
*/

/*

Переменная доступна (грубо) внутри тех фигурных скобок, где она определена. 
Область кода, из которой допустимо обращение к переменной, называется "областью видимости"
Локальная переменная "перекрывает" глобальную с тем же именем.
Однако локальная переменная не может 
перекрыть другую локальную переменную с тем же именем — возникнет ошибка компиляции.

class Program
{
	static string globalVariable = "Global variable";

	static void MethodA()
	{
		if (globalVariable == "")
		{
			string temporalVariable = "Temporal variable";
			Console.WriteLine(temporalVariable);
		}

		string localVariable = "Local variable";
		
		// Так можно — эта переменная используется в той же области, где и объявлена:
		Console.WriteLine(localVariable);
		
		// Так нельзя — temporalVariable определена только внутри блока if:
		// Console.WriteLine(temporalVariable); 
	}

	static void MethodB()
	{
		// Console.WriteLine(localVariable); //Нельзя — переменная определена в другом методе.
		Console.WriteLine(globalVariable); //Можно — это глобальная переменная

	}
}
*/

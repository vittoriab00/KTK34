
using System;
{
	// Ввод данных уравнения - значения a, b и c
	// После ввода данных мы обрезаем лишние пробелы по краям методом Trim()
	// и преобразовываем тип string во float
	Console.Write("Введите значение a = ");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
	float a = float.Parse(Console.ReadLine().Trim());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
	Console.Write("Введите значение b = ");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
	float b = float.Parse(Console.ReadLine().Trim());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
	Console.Write("Введите значение c = ");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
	float c = float.Parse(Console.ReadLine().Trim());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
	// Вычисление дискриминанта
	float d = b * b - 4 * a * c;
	// При дискриминанте меньшим 0 - выводим ошибку
	if (d < 0)
	{
		Console.Write("Дискриминант d < 0<!— hu —>. Решение квадратного уравнения невозможно.");
	}
	else
	{
		// Объявляем корни уравнения
		float x1, x2;
		// При дискриминанте равным 0 оба корня равны
		if (d == 0)
		{
			x1 = x2 = -(b / 2 * a);
		}
		else
		{
			// Извлекаем корень из дискриминанта
			float sqrtD = (float)System.Math.Sqrt(d);
			// Высчитываем корни уравнения
			x1 = (-b + sqrtD) / (2 * a);
			x2 = (-b - sqrtD) / (2 * a);
		}
		// Выводим результат
		Console.Write("d = " + d.ToString() + " x1 = " + x1.ToString() + " x2 = " + x2.ToString());
	}
	// Ждем нажатия клавиши, чтобы завершить выполнение программы
	Console.ReadLine();
}

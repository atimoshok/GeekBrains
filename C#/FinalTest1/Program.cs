// // Practic_1. Консольная шпаргалка

// // Постановка задачи: красиво вывести информацию о примитивных типах данных в виде таблице, со следующим содержанием:
// // тип данных, диапазон значений, количество байтов занимаемые этим типом. Оформить в виде таблице, всё аккуратно и красиво.

// // Новые знания: типы данных, константы типов MinValue и MaxValue, sizeof

// Console.WriteLine($"Тип данных: int | диапазон значений: от {int.MinValue} до {int.MaxValue} | количество байтов занимаемые этим типом: {sizeof(int)}");
// Console.WriteLine($"Тип данных: double | диапазон значений: от {double.MinValue} до {double.MaxValue} | количество байтов занимаемые этим типом: {sizeof(double)}");


// // Practic_2. Консольный калькулятор

// // Постановка задачи: написать программу, которая умеет выполнять следующие действия:
// // сложение, вычитание в две стороны, умножение, деление в две стороны, возведение в степень в две стороны.
// // Количество чисел — два числа. Оформить всё аккуратно и красиво.

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сложение: {firstNumber + secondNumber}");
// Console.WriteLine($"Вычетание: {firstNumber - secondNumber}, в обратную сторону: {secondNumber - firstNumber}");
// Console.WriteLine($"Умножение: {firstNumber * secondNumber}");
// Console.WriteLine($"Деление: {firstNumber / secondNumber}, в обратную сторону: {secondNumber / firstNumber}");
// Console.WriteLine($"Возведение в степень: {Math.Pow(firstNumber, secondNumber)} в обратную сторону: {Math.Pow(secondNumber, firstNumber)}");


﻿//Задание к уроку #2 вопрос #1:
//Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
//Запрос у пользователя минимальной температуры:
Console.WriteLine("Здравствуйте, введите пожалуйста минимальную температуру за сутки:");
//На следующей строке пользователь вводит значение температуры.
//Так как у кого-то ртутные уличные термометры,
//а у кого-то электронные с датчиком,
//то предполагаю, что введёное значение будет с десятыми или даже сотыми значениями
//поэтому ввожу переменную float
float tMin = float.Parse(Console.ReadLine());
//Запрос у пользователя максимальной температуры:
Console.WriteLine("Здравствуйте, а теперь введите пожалуйста максимальную температуру за сутки:");
float tMax = float.Parse(Console.ReadLine());
//Среднесуточная температура считается как средняя двух, то есть (a+b)/2
//По правилам хорошего тона необходимо отдельно ввести рассчётную переменную
//а потому выводить на консоль,
//но так как программа короткая допускается сразу в консоль ввести расчёт
Console.WriteLine("Cреднесуточная температура: " + (tMin + tMax) / 2 + " °С");
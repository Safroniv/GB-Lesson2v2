//Задание к уроку #2 вопрос #2:
//Запросить у пользователя порядковый номер текущего месяца и вывести его название.

//Запрос порядкового номера текущего месяца:
Console.WriteLine("Здравствуйте, введите пожалуйста порядковый номер текущего месяца:");
//Пользователь вводит номер месяца, по-этому принимаю значения целочисленных величин
int num = int.Parse(Console.ReadLine());
switch(num)
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Февраль");
        break;
    case 3:
        Console.WriteLine("Март");
        break;
    case 4:
        Console.WriteLine("Апрель");
        break;
    case 5:
        Console.WriteLine("Май");
        break;
    case 6:
        Console.WriteLine("Июнь");
        break;
    case 7:
        Console.WriteLine("Июль");
        break;
    case 8:
        Console.WriteLine("Август");
        break;
    case 9:
        Console.WriteLine("Сентябрь");
        break;
    case 10:
        Console.WriteLine("Октябрь");
        break;
    case 11:
        Console.WriteLine("Ноябрь");
        break;
    case 12:
        Console.WriteLine("Декабрь");
        break;
    default:
        Console.WriteLine("Введите номер месяца от 1 до 12");
        break;
}

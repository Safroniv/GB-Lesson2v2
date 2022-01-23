//Задание к уроку #2 вопрос #4:
//Для полного закрепления понимания простых типов
//найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
//только за место динамических, по вашему мнению, данных
//(это может быть дата, название магазина, сумма покупок) подставляйте переменные,
//которые были заранее заготовлены до вывода на консоль.

//Сначала ввод переменных заранее заготовленных:
string nameCompany = "        ООО \"ЛАЗУРИТ-Д\"          ";
string product1 = "1СК";
string cost1 = "107000.00";
string summ = cost1;
DateTime dateAndTime = new DateTime(2014, 8, 5, 11, 23, 00);
string numCheque = "00000012";
string numKKM = "10123330";
string numTIN = "007713286972";
string numECTP = "1439796361";
string numChequeSumm = "00000017";
string numOperation = "#087654";

//После печать чека с параметрами:
Console.WriteLine($"+---------------------------------+");
Console.WriteLine($"|                                 |");
Console.WriteLine($"|{nameCompany}|");
Console.WriteLine($"|{product1}                    {cost1}-|");
Console.WriteLine($"|ИТОГ                    {summ}|");
Console.WriteLine($"|{dateAndTime}         ОП: 1|");
Console.WriteLine($"|ЧЕК:{numCheque}           ФИСКАЛЬНЫЙ|");
Console.WriteLine($"|                     ККМ {numKKM}|");
Console.WriteLine($"|                 ИНН {numTIN}|");
Console.WriteLine($"|                  ЭКЛЗ {numECTP}|");
Console.WriteLine($"|                 {numChequeSumm} {numOperation}|");
Console.WriteLine($"+---------------------------------+");

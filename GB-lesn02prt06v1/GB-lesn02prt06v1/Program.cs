// Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели,
// к примеру, чтобы описать работу какого либо офиса.
// Явный пример - офис номер 1 работает со вторника до пятницы,
// офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.

namespace WorkDaysOfOffece
{
    class Program
    {
        [Flags]
        public enum DaysOfWeek
        {
            //Введение битовых масок для дней недели
            Понедельник = 0b_0000001,
            Вторник     = 0b_0000010,
            Среда       = 0b_0000100,
            Четверг     = 0b_0001000,
            Пятница     = 0b_0010000,
            Суббота     = 0b_0100000,
            Воскресенье = 0b_1000000,
        }


        static void Main(string[] args)
        {      
            //дни работы офисов
            DaysOfWeek office01 = (DaysOfWeek)0b_0011111;
            DaysOfWeek office02 = (DaysOfWeek)0b_1111111;
            DaysOfWeek office03 = (DaysOfWeek)0b_1111100;
            DaysOfWeek office04 = (DaysOfWeek)0b_1110011;
            DaysOfWeek office05 = (DaysOfWeek)0b_1110111;
            DaysOfWeek office06 = (DaysOfWeek)0b_1101101;
            DaysOfWeek office07 = (DaysOfWeek)0b_0111110;

           
            Console.WriteLine("Здравствуйте, введите пожалуйста порядковый номер офиса:");
            //Пользователь вводит номер офиса
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office01}.");
                    break;
                case 2:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office02}.");
                    break;
                case 3:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office03}.");
                    break;
                case 4:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office04}.");
                    break;
                case 5:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office05}.");
                    break;
                case 6:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office06}.");
                    break;
                case 7:
                    Console.WriteLine($"Офис #{num}. \nРабочие дни офиса: \n{office07}.");
                    break;
                //указания кейса по умолчанию, если пользователь ввёл значение за рамками 1-7
                default:
                    Console.WriteLine("Извините, но у нас в организации всего 7 офисов");
                    break;
                    
            }
        }
    }
}

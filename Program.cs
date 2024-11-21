using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    internal class Program
    {
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {

            //Задание 4.1
            string year, day;
            int year_number, number_of_the_day;
            bool leap_year = false;
            Console.WriteLine("Задание 4.1");
            while (true) 
            {
                Console.WriteLine("Введите год");
                year = Console.ReadLine();
                try
                {
                    year_number = Convert.ToInt32(year);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }
                if (year_number > 0)
                {
                    break;
                }
                Console.WriteLine("Введено не коректное число");
            }

            //Проверка на наличие високосного года
            if ((year_number % 4 == 0 && year_number % 100 != 0) || year_number % 400 == 0)
            {
                leap_year = true;
            }

            while (true)
            {
                Console.WriteLine("Введите номер дня");
                day = Console.ReadLine();
                try
                {
                    number_of_the_day = Convert.ToInt32(day);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }
                if (leap_year)
                {
                    if (number_of_the_day > 0 && number_of_the_day < 366)
                    {
                        break;
                    }
                }
                else
                {
                    if (number_of_the_day > 0 && number_of_the_day < 365)
                    {
                        break;
                    }
                }
                Console.WriteLine("Введено не коректное число");
            }

            if (!leap_year && number_of_the_day>59) 
            {
                number_of_the_day++;
            }

            if (number_of_the_day <= 31)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day) + " Января");
            }
            if (number_of_the_day >= 32 && number_of_the_day <= 60)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day-31) + " Февраля");
            }
            if (number_of_the_day >= 61 && number_of_the_day <= 91)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 60) + " Марта");
            }
            if (number_of_the_day >= 92 && number_of_the_day <= 121)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 91) + " Апреля");
            }
            if (number_of_the_day >= 122 && number_of_the_day <= 152)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 121) + " Мая");
            }
            if (number_of_the_day >= 153 && number_of_the_day <= 182)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 152) + " Июня");
            }
            if (number_of_the_day >= 183 && number_of_the_day <= 213)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 182) + " Июля");
            }
            if (number_of_the_day >= 214 && number_of_the_day <= 244)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 213) + " Августа");
            }
            if (number_of_the_day >= 245 && number_of_the_day <= 274)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 244) + " Сентября");
            }
            if (number_of_the_day >= 275 && number_of_the_day <= 305)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 274) + " Октября");
            }
            if (number_of_the_day >= 306 && number_of_the_day <= 335)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 305) + " Ноября");
            }
            if (number_of_the_day >= 336)
            {
                Console.WriteLine(Convert.ToString(number_of_the_day - 335) + " Декабря");
            }
            Console.ReadKey();

            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine("Ввидите последовательность чисел");
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int previous_element = arr[0];
            bool flag = true;
            int first_mistake = 1;
            foreach (int i in arr)
            {
                if (i<previous_element)
                {
                    flag = false;
                    break;
                }
                first_mistake++;
                previous_element = i;
            }
            if (flag)
            {
                Console.WriteLine("Последовательность возрастает");
            }
            else
            {
                Console.WriteLine("Последовательность не возрастает. Первый ошибочный элемент - " + Convert.ToString(first_mistake));
            }
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("Задание 2");
            string card_str;
            int card_number;
            while (true)
            {
                Console.WriteLine("Введите число от 6 до 14 включительно");
                card_str = Console.ReadLine();
                try
                {
                    card_number = Convert.ToInt32(card_str);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }
                if (card_number >= 6 && card_number <= 14)
                {
                    break;
                }
                Console.WriteLine("Число вне диапазона");
            }
            switch (card_number)
            {
                case 6: Console.WriteLine("Шестёрка"); break;
                case 7: Console.WriteLine("Семёрка"); break;
                case 8: Console.WriteLine("Восьмёрка"); break;
                case 9: Console.WriteLine("Девятка"); break;
                case 10: Console.WriteLine("Десятка"); break;
                case 11: Console.WriteLine("Валет"); break;
                case 12: Console.WriteLine("Дама"); break;
                case 13: Console.WriteLine("Король"); break;
                case 14: Console.WriteLine("Туз"); break;
            }
            Console.ReadKey();

            //Задание 3
            Console.WriteLine("Задание 3");
            string visitor;
            Console.WriteLine("Кто пришёл?");
            visitor = Console.ReadLine();
            visitor = visitor.ToLower();
            switch (visitor)
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anithing with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;
            }
            Console.ReadKey();

            //Задание 4
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите порядковый номер дня недели");
            string day_num;
            int dayNumber;
            day_num = Console.ReadLine();
            dayNumber = Convert.ToInt32(day_num);
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                DayOfWeek day_4 = (DayOfWeek)dayNumber;
                Console.WriteLine(day_4);
            }
            else
            {
                Console.WriteLine("Число вне диапазона");
            }
            Console.ReadKey();

            //Задание 5
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введити список покупок через запятую без пробелов");
            int quantity = 0;
            string[] basket = Console.ReadLine().Split(',').ToArray();
            foreach (string str in basket) 
            {
                string check = str.ToLower();
                if (check == "hello kitty" || check == "barbie doll")
                {
                    quantity++;
                }
            }
            Console.WriteLine(quantity.ToString());
            Console.ReadKey();
        }
    }
}

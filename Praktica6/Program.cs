using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Praktica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*
            Console.WriteLine("Введите число кратное 3-м и 7-ми.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            if(name2 % 3 == 0 && name2 % 7 == 0)
            {
                Console.WriteLine($"Число {name2} соответствует критериям");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {name2} не соответствует критериям");
                Console.ReadKey();
            }
            */


            //Задание 2
            /*
            Console.WriteLine("Введите первое число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите второе число.");
            string name2 = Console.ReadLine();
            Console.Clear();
            int name3 = Int32.Parse(name1);
            int name4 = Int32.Parse(name2);

            if (name3 > name4)
            {
                Console.WriteLine($"число {name3} больше числа {name4}");
                Console.ReadKey();
            }
            else if (name3 < name4)
            {
                Console.WriteLine($"число {name4} больше числа {name3}");
                Console.ReadKey();
            }
            else if (name3 == name4)
            {
                Console.WriteLine($"число {name3} и число {name4} равны");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка");
                Console.ReadKey();
            }
            */


            //Задание 3
            /*

            Console.WriteLine("Введите число. 0 - это выход.");
            int sum = 0;
            int i = 0;
            int name2 = 0;


            do
            {
                Console.WriteLine($"Введите {i += 1}-е число");

                string name1 = Console.ReadLine();
                name2 = Int32.Parse(name1);
                
                if (name2 == 0)
                {
                    i++;
                    sum +=  name2;
                    
                }
                
            }
            while (name2 != 0);
            Console.WriteLine($"Введено чисел: {i-2}");
            Console.WriteLine($"Сумма чисел {sum}");
            Console.ReadKey();
            */


            //Задание 4
            /*
            Console.WriteLine("Введите число. 1-7(В зависимости от дня недели.)");
            int name1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            switch (name1)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Вторник");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Среда");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Четверг");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Пятница");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("Суббота");
                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("Воскресенье");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    Console.ReadKey();
                    break;
            }
            */


            //Задание 5
            /*
            Console.WriteLine("Введите день недели");
            string name1 = Console.ReadLine();
            Console.Clear();

            switch (name1)
            {
                case "понедельник":
                    Console.WriteLine("1");
                    Console.ReadKey();
                    break;

                case "вторник":
                    Console.WriteLine("2");
                    Console.ReadKey();
                    break;

                case "среда":
                    Console.WriteLine("3");
                    Console.ReadKey();
                    break;

                case "четверг":
                    Console.WriteLine("4");
                    Console.ReadKey();
                    break;

                case "пятница":
                    Console.WriteLine("5");
                    Console.ReadKey();
                    break;

                case "суббота":
                    Console.WriteLine("6");
                    Console.ReadKey();
                    break;

                case "воскресенье":
                    Console.WriteLine("7");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    Console.ReadKey();
                    break;
            }
            */



            //Задание 6

            Console.WriteLine("Введите количество чисел фебоначи)");
            int name1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int fib1 = 0;
            int fib2 = 1;

            if (name1 == 1)
            {
                Console.WriteLine(fib2);
            }
            else if (name1 == 2)
            {
                Console.WriteLine(fib2);
                Console.WriteLine(fib2);
            }
            else if (name1 == 0)
            {
                Console.WriteLine(" ");
            }

            else
            {

                for (int i = 0; i < name1; i++)
                {
                    Console.WriteLine($"{fib2}");
                    fib1 = fib1 + fib2;
                    fib2 = fib1 + fib2;
                }
            }
            Console.ReadKey();

        }
    }
}

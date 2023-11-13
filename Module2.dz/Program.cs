using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.dz
{
    internal class Program
    {

            static void Exmpl01()
            {
                Console.WriteLine("Введите текст (для завершения введите точку):");

                string text = Console.ReadLine();
                int space = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    char a = text[i];

                    if (a == '.')
                    {
                        break;
                    }

                    if (a == ' ')
                    {
                        space++;
                    }
                }

                Console.WriteLine("Количество пробелов: " + space);

            }
            static void Exmpl02()
            {
                Console.WriteLine("Введите номер трамвайного билета (6-значное число): ");
                string str = Console.ReadLine();
                int[] arr = str.Select(x => x - '0').ToArray();
                int sum1 = arr[0] + arr[1] + arr[2];
                int sum2 = arr[5] + arr[4] + arr[3];
                if (sum1 == sum2)
                {
                    Console.WriteLine("У вас счастливый билет");
                }
                else
                {
                    Console.WriteLine("У вас несчастный билет , вы умрете");
                }
            }
            static void Exmpl04()
            {
                Console.WriteLine("Введите диапозон чисел: ");
                string string01 = Console.ReadLine();
                string string02 = Console.ReadLine();
                int A = Int32.Parse(string01);
                int B = Int32.Parse(string02);
                int rep = 0;
                if (A > B)
                {
                    rep = A;
                    A = B;
                    B = rep;

                }
                for (int i = A; i <= B; i++)
                {

                    string repeatedNumber = string.Join(" ", Enumerable.Repeat(i.ToString(), i));
                    Console.WriteLine(repeatedNumber);

                }
            }
            static void Exmpl06()
            {
                Random rand = new Random();
                rand.Next(100);
                int a = rand.Next(100);
                int b = rand.Next(100);
                int c = rand.Next(100);

                Console.WriteLine($"{a}  {b}  {c}");
            }
            static void Exmpl08()
            {
                Console.WriteLine("Введите число в снатиметрах : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{a} cm = " + a / 100 + "m");
                Console.ReadKey(true);
            }
            static void Exmpl10()
            {
                Console.Write("Введите число :");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = a / 10;
                int c = a % 10;
                int sum = b + c;
                int proizvedenie = b * c;
                Console.WriteLine($"a. число десятков в нем {b};\r\n\r\nb. число единиц в нем {c};\r\n\r\nc. суммa его цифр {sum};\r\n\r\nd. произведение его цифр {proizvedenie}");

                Console.ReadKey(true);
            }
            static void Exmpl12()
            {
                Console.Write("Введите радиус круга:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите сторону квадрата:");
                int b = Convert.ToInt32(Console.ReadLine());

                double p = 3.14;
                double PloshadKruga = a * a * p;
                int PloshadKvadrata = b * b;



                if (PloshadKruga > PloshadKvadrata)
                {
                    Console.WriteLine($"Площадь круга больше : {PloshadKruga} > {PloshadKvadrata}");
                }
                else
                {
                    Console.WriteLine($"Площадь квадрата больше : {PloshadKvadrata} > {PloshadKruga}");
                }
                Console.ReadKey();

            }
            static void Exmpl14()
            {
                Console.WriteLine("Введите значения первой электрической цепи : ");
                Console.WriteLine("Напряжение : ");
                int E1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сопротивление : ");
                int R1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значения второй электрической цепи : ");
                Console.WriteLine("Напряжение : ");
                int E2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сопротивление : ");
                int R2 = Convert.ToInt32(Console.ReadLine());
                int I1 = E1 / R1;
                int I2 = E2 / R2;
                if (I1 == I2)
                {
                    Console.WriteLine($"Сила тока электрических цепей одинаковы ");
                }
                if (I1 < I2)
                {
                    Console.WriteLine($"Сила первой цепи {I1} меньше второй {I2} ");
                }
                if (I2 < I1)
                {
                    Console.WriteLine($"Сила второй цепи {I2} меньше первой {I1} ");
                }
            }
            static void Exmpl16()
            {
                Console.WriteLine("Уравнение : y= 7x²-3x+6");
                Console.WriteLine("Введите значение x:");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = Math.Pow(7 * x, 2) - (3 * x) + 6;
                Console.WriteLine($"y = {y}");
            }
            static void Exmpl18()
            {
                Console.WriteLine("Введите сторону квадрата : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Периметр квадрата = {a * 4} ");
            }
            static void Exmpl20()
            {
                Console.WriteLine("Земля — идеальная сфера с радиусом R 6350 км");
                int R = 6350;
                Console.WriteLine("Задайте высоту от земли : ");
                int h = Convert.ToInt32(Console.ReadLine());
                double d = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(h, 2));
                Console.WriteLine($"Pасстояние до линии горизонта равняется {d}");
            }
            static void Exmpl39()
            {
                Console.WriteLine("Введите количество :");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = 20;
                for (int i = 0; i < a; i++)
                {
                    Console.Write($"{b} ");
                }
            }
            static void Exmpl13()
            {
                Console.WriteLine("Введите данные первого материала : ");
                Console.Write("m = ");
                int m1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("V = ");
                int V1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите данные второго материала : ");
                Console.Write("m = ");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("V = ");
                int V2 = Convert.ToInt32(Console.ReadLine());
                double p1 = m1 / V1;
                double p2 = m2 / V2;
                if (p1 == p2)
                {
                    Console.WriteLine("Плотность материалов одинаковы");

                }
                else
                {
                    if (p1 > p2)
                    {
                        Console.WriteLine($"Плотность первого материала {p1} больше второго {p2}");
                    }
                    else
                    {
                        Console.WriteLine($"Плотность второго материала {p2} больше первого {p1}");
                    }
                }
            }
            static void Exmpl26()
            {
                Console.Write("Введите 4 значное число : ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 1000)
                {
                    int b = a / 1000;
                    int c = (a - b * 1000) / 100;
                    int d = ((a % 1000) % 100) / 10;
                    int e = ((a % 1000) % 100) % 10;
                    int sum = b + c + d + e;
                    int proizvedenie = b * c * d * e;
                    Console.WriteLine("Сумма цифр " + sum);
                    Console.WriteLine("Произведение цифр " + proizvedenie);
                }
                else
                {
                    Console.WriteLine("Значение не четырехзначное");
                }
                Console.ReadKey();


            }
            static void Exmpl42()
            {
                Console.WriteLine("Введите цифру :");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 9)
                {
                    Console.WriteLine("Это не цифра топас");
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                        Console.WriteLine($"{a} * {i + 1} = {a * (i + 1)}");
                }
            }
            static void Exmpl07()
            {
                Console.WriteLine("5");
                Console.WriteLine("10");
                Console.WriteLine("21");
            }
            static void Exmpl09()
            {
                Console.WriteLine("Сколько дней прошло :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"За этот период прошло {a / 7} недель ");
            }
            static void Exmpl17()
            {
                Console.WriteLine("Уравнение : x= 12a²+7a-16");
                Console.WriteLine("Введите значение a:");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = Math.Pow(12 * x, 2) + (7 * x) - 16;
                Console.WriteLine($"a = {y}");
            }
            static void Exmpl22()
            {
                Console.WriteLine("Введите первое число: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"a) Среднее арифметическое чисел = {(a + b) / 2};\nb) Cреднее геометрическое чисел = {Math.Sqrt(a * b)} ");
            }
            static void Exmpl30()
            {
                Console.Write("Введите первое расстояние в км ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе расстояние в футах ");
                double b = Convert.ToInt32(Console.ReadLine());
                b = b * 0.000305;
                if (a == b)
                {
                    Console.WriteLine("Расстояния одинаковы");
                }
                if (a > b)
                {
                    Console.WriteLine("Первое растояние больше второго");
                }
                else
                {
                    Console.WriteLine("Второе расстояние больше первого");
                }


            }
            static void Main(string[] args)
            {
                Exmpl30();

                Console.ReadKey(true);
            }
        }
    }

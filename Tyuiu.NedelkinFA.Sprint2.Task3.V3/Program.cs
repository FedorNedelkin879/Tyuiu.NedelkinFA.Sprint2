using Tyuiu.NedelkinFA.Sprint2.Task3.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Неделькин Ф. А. | ИИПБ-24-1";
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                    *");
Console.WriteLine("* Тема:                                                                                        *");
Console.WriteLine("* Задание #                                                                                    *");
Console.WriteLine("* Вариант #                                                                                    *");
Console.WriteLine("* Выполнил: Неделькин Ф. А. | ИИПБ-24-1                                                        *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                     *");
Console.WriteLine("*                                                                                              *");
Console.WriteLine("*                                                                                              *");
Console.WriteLine("*                                                                                              *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                             *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("*                                                                                              *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                   *");
Console.WriteLine("************************************************************************************************");
Console.WriteLine("napishi x");
double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine("zn funk " + res);

Console.ReadKey();
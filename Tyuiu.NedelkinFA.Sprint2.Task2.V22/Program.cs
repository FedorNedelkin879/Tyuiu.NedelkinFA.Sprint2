using Tyuiu.NedelkinFA.Sprint2.Task2.V22.Lib;

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

Console.WriteLine("Введите значение переменной Xэ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Yй: ");
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);

if (res)
{
    Console.WriteLine("Точка находится в зфыао ");
}
else
{
    Console.WriteLine("Точка не находится в ывщпзов");
}
Console.ReadKey();
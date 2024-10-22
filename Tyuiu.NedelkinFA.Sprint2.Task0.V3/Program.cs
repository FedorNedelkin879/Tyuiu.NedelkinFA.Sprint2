using Tyuiu.NedelkinFA.Sprint2.Task0.V3.Lib;

DataService ds = new DataService();

int x = 45;
int y = 127;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

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

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

for  (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();
using Tyuiu.NedelkinFA.Sprint2.Task1.V8.Lib;

DataService ds = new DataService();
int a = 15;
int b = 16;
int c = 14;
int d = 17;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

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

Console.WriteLine("a" + a);
Console.WriteLine("b" + b);
Console.WriteLine("c" + c);
Console.WriteLine("d" + d);

for  (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();

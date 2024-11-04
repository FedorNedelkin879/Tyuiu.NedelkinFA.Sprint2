using Tyuiu.NedelkinFA.Sprint2.Task2.V22.Lib;

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
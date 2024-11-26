using Tyuiu.NedelkinFA.Sprint2.Task6.V12.Lib;

DataService ds = new DataService();
Console.WriteLine("Введите год:");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца:");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день:");
int day = Convert.ToInt32(Console.ReadLine());

string res;

if (month < 1 || month > 12 || day < 1 || day > 31)
{
    res = "Неверные входные данные.";
}
else
{
    res = "Предыдущий день: " + ds.FindDateOfPreviousDay(year, month, day);
}
Console.WriteLine(res);
Console.ReadKey();

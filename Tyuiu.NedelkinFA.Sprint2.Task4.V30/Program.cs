using Tyuiu.NedelkinFA.Sprint2.Task4.V30.Lib;

DataService ds  = new DataService();

Console.WriteLine("napishi x");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("napishi YyyYyy");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);
Console.WriteLine("zn f" + res);

Console.ReadKey();
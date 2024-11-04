using Tyuiu.NedelkinFA.Sprint2.Task3.V3.Lib;

DataService ds = new DataService();

Console.WriteLine("napishi x");
double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine("zn funk " + res);

Console.ReadKey();
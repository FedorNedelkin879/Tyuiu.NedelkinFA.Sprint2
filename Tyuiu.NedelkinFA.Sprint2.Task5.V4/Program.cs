using System.Threading.Channels;
using Tyuiu.NedelkinFA.Sprint2.Task5.V4.Lib;
DataService ds  = new DataService();
Console.WriteLine("nomer");
int numMounth = Convert.ToInt32(Console.ReadLine());

string res;

if ((numMounth < 1) || (numMounth > 12))
{
    res = "neverno lox";
}
else
{
    res = "eto:" + ds.FindCardSuit(numMounth);
}
Console.WriteLine(res);
Console.ReadKey();
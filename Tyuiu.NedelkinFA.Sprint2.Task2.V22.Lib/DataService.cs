using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NedelkinFA.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 8 && y >= 2 && y <= 5) || // Левая верхняя часть
(x >= 9 && x <= 12 && y >= 2 && y <= 5) || // Правая верхняя часть
(x >= 4 && x <= 7 && y == 6) || // Средняя горизонтальная линия
(x == 7 && y >= 7 && y <= 9) || // Вертикальная линия слева
(x == 10 && y >= 6 && y <= 9) || // Вертикальная линия справа
(x >= 9 && x <= 11 && y == 6) || // Нижняя центральная область, включая (9, 6)
(x == 4 && y == 10) || // Точка в (4, 10)
(x >= 2 && x <= 7 && y == 12)) // Нижняя горизонтальная линия
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}

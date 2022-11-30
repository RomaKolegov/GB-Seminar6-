/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double getIndexEquationsFromUser(string message)
{
    Console.WriteLine(message);
    double equation = Convert.ToDouble(Console.ReadLine());
    return equation;
}
double equationX(double k1, double b1, double k2, double b2)
{
    double resultX = (b2 - b1) / (k1 - k2);
    return resultX;
}
double equationY(double k1, double b1, double x)
{
    double resultY = k1 * x + b1;
    return resultY;
}
double k1 = getIndexEquationsFromUser("Введите k1");
double b1 = getIndexEquationsFromUser("Введите b1");
double k2 = getIndexEquationsFromUser("Введите k2");
double b2 = getIndexEquationsFromUser("Введите b2");
double x = equationX(k1, b1, k2, b2);
double y = equationY(k1, b1, x);
Console.WriteLine($"Точка пересечения прямых равна ({x}:{y})");

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double GetIntValueFromUser(string text) // функция получения числа от пользователя в double
{
    double num = 0;
    bool flag = true;
    do
    {
        Console.Write($"{text}: ");
        flag = Double.TryParse(Console.ReadLine(), out num);
    } while (!flag);
    return num;
}

// y = k1 * x + b1;
// y = k2 * x + b2;
// x = (b2 - b1) / (k1 - k2);
// y = (k1 * (b2 - b1) / (k1 - k2)) + b1;

string Formula(double b1, double b2, double k1, double k2)
{
    string result = " ";
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"Точка пересечения ({x}, {y})";
    return result;
}
double b1 = GetIntValueFromUser("Введите значение 1: ");
double b2 = GetIntValueFromUser("Введите значение 2: ");
double k1 = GetIntValueFromUser("Введите значение 3: ");
double k2 = GetIntValueFromUser("Введите значение 4: ");
Console.WriteLine(Formula(b1, b2, k1, k2));
Console.Clear();
Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x3");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y3");
int y3 = Convert.ToInt32(Console.ReadLine());

double lengthA = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2));
double lengthB = Math.Sqrt(Math.Pow((x2-x3), 2) + Math.Pow((y2-y3), 2));
double lengthC = Math.Sqrt(Math.Pow((x3-x1), 2) + Math.Pow((y3-y1), 2));

double geronsP = Math.Abs((lengthA + lengthB + lengthC)) / 2;
double result = Math.Round(Math.Sqrt(geronsP * Math.Abs((geronsP - lengthA) * (geronsP - lengthB) * (geronsP - lengthC))), 2);
Console.WriteLine($"Площадь треугольника = {result}");
// 17. Напишите программу, которая 
// 1  принимает на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xCoordinate, yCoordinate);
// string result = quarter > 0 
//                 ? $"Указанные координаты соответствуют четверти -> {quarter}" 
//                 : "Введены некорректные координаты";
// Console.WriteLine(result);

int Quarter (int x, int y)
{
    if(x > 0 && y > 0) return 1; // x > 0, y > 0
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}


double sqrt = Math.Sqrt(5);
double d = 5.099876453;
double sqrtRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(d + "\n" + sqrtRound);

// 1   1
// 2   2
// 3   9
// 4   16
// 5   25

// Math.Pow(count, 3);

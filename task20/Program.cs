// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Вычисление расстояния между взятыми на плоскости двумя точками А(х А; у А) и В(х В; у В), 
// выполняется по формуле d = √((хА – хВ)2 + (уА – уВ)2), 
// где d – длина отрезка, который соединяет эти точки на плоскости.

Console.Clear();
Console.WriteLine("Введите координату Х1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

double length = Math.Sqrt((X1 - X2)*(X1 - X2) + (Y1 - Y2)*(Y1 - Y2));
Console.WriteLine(length);
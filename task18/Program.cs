// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: 1 - 4 ");
int N = int.Parse(Console.ReadLine()!);

if(N == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
if(N == 2)
{
    Console.WriteLine("X < 0, Y > 0");
}
if(N == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
if(N == 4)
{
    Console.WriteLine("X > 0, Y < 0");
}
else
{
   Console.WriteLine("Error"); 
}
// -oo
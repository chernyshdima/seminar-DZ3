// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1 первой точки");
 int x1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату y1 первой точки");
 int y1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату z1 первой точки");
 int z1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату x2 второй точки");
 int x2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату y2 второй точки");
 int y2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату z2 второй точки");
 int z2 = Convert.ToInt32(Console.ReadLine());

 int A = x2 - x1;
 int B = y2 - y1;
 int C = z1 - z2;

 double length = Math.Sqrt(A * A + B * B + C * C);
 Console.WriteLine($"Длинна отрезка {length}");

 int ReadInt(string message)
 {
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
 }




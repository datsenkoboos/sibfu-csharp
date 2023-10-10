// 1
// Console.WriteLine("What is your name?");
// string name = Console.ReadLine()!;
// Console.WriteLine("What language do you already know?");
// string lang = Console.ReadLine()!;
// Console.WriteLine($"{name} knows {lang}");
// 2
// double x = Convert.ToDouble(Console.ReadLine());
// double y = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine((Math.Atan(x / y)/Math.PI) * 180);
// 3
// int s = 163;
// int v = Convert.ToInt32(Console.ReadLine());
// int t = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{v * t % s}, {v * t / s}");
// 4
// var random = new Random();
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(random.Next(a, b + 1));
// 5
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((a / c) * (b / d) - (a * b - c) / (c * d) + Math.Sqrt(d));
// 6
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int p = (a + b + c) / 2;
Console.WriteLine(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
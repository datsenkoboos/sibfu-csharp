//1
// Console.WriteLine("Введите номер Серёжи в шеренге");
// int n = Convert.ToInt16(Console.ReadLine());
// if (n % 2 == 0)
// {
// Console.WriteLine("Второй");
// }
// else
// {
// Console.WriteLine("Первый");
// }
// 2
// Console.WriteLine("Введите длины сторон треугольника");
// double a = Convert.ToDouble(Console.ReadLine());
// double b = Convert.ToDouble(Console.ReadLine());
// double c = Convert.ToDouble(Console.ReadLine());
// double[] m = new double[] { a, b, c };
// Array.Sort(m);
// if (a+b>c && c+b>a && a + c > b) {
//     if (m[0] * m[0] + m[1] * m[1] == m[2] * m[2]) {
//         Console.WriteLine("Данный треугольник является прямоугольным");
//     } else {
//         Console.WriteLine($"Величина угла C в заданном треугольнике: {Math.Acos((a*a + b*b - c*c)/(2*a*b))*180/Math.PI}");
//     }
// } else {
//     Console.WriteLine("Фигура с такими сторонами не может являться треугольником");
// }
// 3
// Console.WriteLine("Введите номер Павла в очереди");
// int paul_n = Convert.ToInt16(Console.ReadLine())/2;
// int t = 8 * 3 + 1;
// if (paul_n >= t)
// {
// Console.WriteLine("Имеет смысл прийти сюда завтра");
// }
// else
// {
// int tm = (paul_n-1) * 20;
// int hours = tm / 60;
// int mins = tm % 60;
// Console.WriteLine($"Время ожидания: {hours} ч {mins} мин");
// }  
// 4
// Console.WriteLine("Выберите условия вклада:");
// int v = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сумму вклада:");
// int sum = Convert.ToInt32(Console.ReadLine());
// switch (v)
// {
// case 1:
// Console.WriteLine($"Ваша прибыль: {sum * 0.07} рублей");
// break;
// case 2:
// Console.WriteLine($"Ваша прибыль: {sum * Math.Pow(1.08, 3) - sum} рублей");
// break;
// case 3:
// Console.WriteLine($"Ваша прибыль: {sum * Math.Pow(1.1, 5) - sum} рублей");
// break;
// default: Console.WriteLine("Извините, такой опции нет");
// break;
// } 
// 5
// Console.WriteLine("Введите скорость автомобиля в км/ч");
// int speed = Convert.ToInt32(Console.ReadLine());
// int difference = speed - 90;
// if ( difference <=20 ) {
// Console.WriteLine("Скорость автомобиля допустима на данном участке");
// }
// else if (difference <= 40) {
// Console.WriteLine("Мера наказания: штраф в размере 500 рублей");
// }
// else if (difference <=60){
// Console.WriteLine("Мера наказания: штраф в размере 1500 рублей");
// }
// else if (difference <= 80)
// {
// Console.WriteLine("Мера наказания: штраф в размере 2500 рублей или лишение прав на 4 месяца");
// }
// else
// {
// Console.WriteLine("Мера наказания: штраф в размере 5000 рублей или лишение прав на полгода");
// }
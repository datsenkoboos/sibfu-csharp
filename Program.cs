// 1
// int ans = new Random().Next(1, 10 + 1);
// Console.WriteLine("Type in your guess:");
// int guess = Convert.ToInt16(Console.ReadLine());
// while (guess != ans) {
//     Console.WriteLine($"You guessed incorrectly. The correct answer is {(ans > guess ? "greater than your guess" : "smaller than your guess")}");
//     guess = Convert.ToInt16(Console.ReadLine());
// }
// Console.WriteLine("You guessed correctly!");
// 2
// Console.WriteLine("Type in N:");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int sumSquared = 0;
// for (int i = 1; i <= N; i++) {
//     if (sumSquared > 500) break;
//     sum += i;
//     sumSquared += Convert.ToInt32(Math.Pow(i, 2));
// }
// Console.WriteLine($"Sum: {sum}, squared sum: {sumSquared}");
// 3
// Console.WriteLine("Type in N:");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] pullUps = new int[N];
// for (int i = 0; i < N; i++) {
//     int quantity = Convert.ToInt32(Console.ReadLine());
//     pullUps[i] = quantity;
// }
// // int gotTwo = pullUps.Where(quantity => quantity < 12).ToArray().Length;
// int gotThree = pullUps.Where(quantity => quantity >= 12 && quantity < 14).ToArray().Length;
// int gotFour = pullUps.Where(quantity => quantity >= 14 && quantity < 16).ToArray().Length;
// int gotFive = pullUps.Where(quantity => quantity >= 16).ToArray().Length;
// Console.WriteLine($"Students that got three: {gotThree}, students that got four: {gotFour}, and students that got five: {gotFive}.");
// Console.WriteLine($"Maximum: {pullUps.Max()}, Minimum: {pullUps.Min()}");
// 4
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int C = Convert.ToInt32(Console.ReadLine());
// int D = Convert.ToInt32(Console.ReadLine());
// double[] values = new double[10];
// for (int x = 1; x < 10 + 1; x++) {
//     double Y = A * Math.Sqrt(B * x + D) - C * x;
//     values[x - 1] = Y;
// }
// double positiveValues = values.Where(value => value > 0).ToArray().Sum();
// double avg = values.Sum() / values.Length;
// Console.WriteLine($"Positive values: {positiveValues}, Average: {avg}");
// 5
// Console.WriteLine("Type in N:");
// int N = Convert.ToInt32(Console.ReadLine());
// double[] values = new double[N];
// Console.WriteLine("Type in values:");
// for (int i = 0; i < N; i++) {
//     double value = Convert.ToDouble(Console.ReadLine());
//     values[i] = value;
// }
// double maxValue = values.Max();
// int maxIndex = Array.IndexOf(values, maxValue);
// List<double> l = new List<double>(values);
// l.RemoveAt(maxIndex);
// l.Add(maxValue);
// Console.WriteLine(string.Join(",", l));
// 6
// double R = Convert.ToDouble(Console.ReadLine());
// int intersectionsCounter = 0;
// for (int i = 0; i < 4; i++) {
//     double[] cords = Console.ReadLine()!.Split(',').Select(value => Convert.ToDouble(value)).ToArray();
//     double x = cords[0];
//     double y = cords[1];
//     double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
//     if (distance <= 2 * R) {
//         intersectionsCounter += 1;
//     }
// }
// Console.WriteLine(intersectionsCounter);
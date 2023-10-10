// void product(int a, int b) {
//     Console.WriteLine(a * b);
// }
// void getLMM(IEnumerable<int> col) {
//     Console.WriteLine(col.Count());
//     var colMin = col.Min();
//     var colMax = col.Max();
//     Console.WriteLine(colMin);
//     Console.WriteLine(colMax);
//     product(colMin, colMax);
// }
// getLMM(new List<int>{2,3,4});


// Dictionary<string, int> pMoney = new Dictionary<string, int>();
// pMoney.Add("Masha", 10000);
// pMoney.Add("Petya", 30000);
// pMoney.Add("Vasya", 100000);
// Console.WriteLine("Type in name and sum, comma-separated");
// string[] data = Console.ReadLine()!.Split(',');
// if (pMoney.ContainsKey(data[0])) {
//     pMoney[data[0]] = pMoney[data[0]] + Convert.ToInt32(data[1]);
//     Console.WriteLine($"{data[0]}, your balance have been changed! The current balance is {pMoney[data[0]]} roubles.");
// } else {
//     pMoney[data[0]] = Convert.ToInt32(data[1]);
//     Console.WriteLine($"Thank you for becoming our customer! {data[0]}, your balance have been changed! The current balance is {pMoney[data[0]]} roubles.");
// }
// void depositAdv(int sum) {
//     double profit = sum;
//     for (int i = 0; i < 3; i++) {
//         profit *= 1.17;
//     }
//     Console.WriteLine($"You can use our bank's standard deposit! You will get {Math.Floor(profit)} after putting {sum} for 3 years with 17% annual interest rate. Visit our mobile app to activate the deposit.");
// }
// depositAdv(1000);


// string getLongest(string sentence) {
//     string[] words = sentence.Split(' ');
//     return words.MaxBy(word => word.Length);
// }
// Console.WriteLine(getLongest("The Tower of London was built in the 15th century"));


// bool validatePassword(string password) {
//     if (password.Length >= 6 && password.Length <= 12) {
//         string alph = "abcdefghijklmnopqrstuvwxyz";
//         string alphUpper = "abcdefghijklmnopqrstuvwxyz".ToUpper();

//         bool containsSpecialSymbol = password.Any(c => "!@#$%^&*()_+".Contains(c));
//         bool containsNumber = password.Any(c => "0123456789".Contains(c));
//         bool containsLowerCaseLatin = password.Any(c => alph.Contains(c));
//         bool containsUpperCaseLatin = password.Any(c => alphUpper.Contains(c));
        
//         return containsSpecialSymbol && containsNumber && containsLowerCaseLatin && containsUpperCaseLatin;
//     }
//     return false;
// }
// Console.WriteLine(validatePassword(Console.ReadLine()));
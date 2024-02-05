using System;

void printCustomer (Customer cust)
{
    string output = string.Format($"{cust.FullName} - Нежность: {cust.GentleRate}");
    if (cust.Smartphone != null)
        output += string.Format($", Смартфон: {cust.Smartphone.SerialNumber}.");
    else output += ".";
    Console.WriteLine(output);
}

List<GentleSmartphone> smartphones = new List<GentleSmartphone>
{
    new GentleSmartphone(new Random().Next(0, 1000), 100),
    new GentleSmartphone(new Random().Next(0, 1000), 60),
    new GentleSmartphone(new Random().Next(0, 1000), 200),
    new GentleSmartphone(new Random().Next(0, 1000), 180)
};
List<Customer> customers = new List<Customer>
{
    new Customer("Some guy", 100),
    new Customer("Some guy 2", 120),
    new Customer("Some guy 3", 80),
    new Customer("Some guy 4", 50)
};
Factory factory = new Factory(customers);
factory.Smartphones = smartphones;

Console.WriteLine("Смартфоны:");
foreach(GentleSmartphone smar in smartphones)
{
    Console.WriteLine($"#{smar.SerialNumber} - {smar.Sensor.Sensitivity}");
}

Console.WriteLine("Наши покупатели до:");
foreach(Customer cust in customers)
    printCustomer(cust);

factory.SaleSmartphone();

Console.WriteLine("Наши покупатели после:");
foreach (Customer cust in customers)
    printCustomer(cust);

Console.WriteLine("Смартфоны после:");
if (smartphones.Count() == 0) Console.WriteLine("Пусто");
else
{
    foreach (GentleSmartphone smar in smartphones)
    {
        Console.WriteLine($"#{smar.SerialNumber} - {smar.Sensor.Sensitivity}");
    }
}
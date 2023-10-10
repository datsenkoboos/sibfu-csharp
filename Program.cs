using static Student;

class Program
{
    static void Main()
    {
        Student? student = null;

        while (true)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Init");
            Console.WriteLine("2. Print info");
            Console.WriteLine("3. Get money");
            Console.WriteLine("4. Spend money");

            int option = int.Parse(Console.ReadLine()!);
            if (student == null && option != 1) {
                Console.WriteLine("Initialize student first");
                continue;
            }
            switch (option)
            {
                case 1:
                    Console.WriteLine("Type in student's last name, first name and patronymic.");
                    string name = Console.ReadLine()!;
                    Console.WriteLine("Type in student's speciality");
                    string speciality = Console.ReadLine()!;
                    student = new Student(name, speciality);
                    break;
                case 2:
                    Console.WriteLine($"{student!.Name}, {student.Speciality}, {student.ScholarshipAmount}rub.");
                    break;
                case 3:
                    Console.WriteLine(student!.ReceiveScholarship());
                    break;
                case 4:
                    Console.WriteLine("Type in what do you want to spend your scholarship on.");
                    string item = Console.ReadLine()!;
                    Console.WriteLine($"Type in amount of money that you want to spend on {item}.");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(student!.SpendScholarship(amount, item));
                    break;
                default:
                    Console.WriteLine(student!.Balance);
                    break;
            }
        }
    }
}

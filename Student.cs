public class Student
{
    public string Name { get; private set; }
    public string Speciality { get; private set; }
    public int ScholarshipAmount { get; set; } = 6000;
    public int Balance { get; private set; } = 0;
    public bool Warning { 
        get
        {
            if (Balance < 100) return false;
            return true;
        } 
    } 

    public Student(string name, string speciality)
    {
        Name = name;
        Speciality = speciality;
    }

    public string ReceiveScholarship()
    {
        if (DateTime.Now.Day == 3)
        {
            Balance += ScholarshipAmount;
            return $"Scholarship was received. +{ScholarshipAmount}rub.";
        }
        return "Scholarship wasn't received, wait for the 20th of the current/next month.";
    }

    public string SpendScholarship(int amount, string itemOfExpenditure)
    {
        if (amount > Balance && Warning)
        {
            return "Transaction failed, unsufficient balance.";
        }

        Balance -= amount;
        return $"Spent {amount}rub. on {itemOfExpenditure}.";
    }
}
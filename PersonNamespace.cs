namespace PersonNamespace
{
    public enum Specialities
    {
        Electrician,
        Mechanic,
        Mathematician,
        Programmer,
        Lawyer
    }

    public class Person
    {
        public string Name;
        public int Age;
        public Specialities Speciality;
        public double Score;

        public Person(string name, int age, Specialities speciality, double score)
        {
            Name = name;
            Age = age;
            Speciality = speciality;
            Score = score;
        }
    }
}
using DepartmentNamespace;
using PersonNamespace;

namespace FactoryNamespace
{
    public class Factory
    {
        private List<Department> Departments;
        private List<Person> Candidates;

        public Factory()
        {
            Departments = new List<Department>();
            Candidates = new List<Person>();

            Departments.Add(new ElectricianDepartment("Electrician Department of SibFU", 3));
            Departments.Add(new MechanicDepartment("Mechanic Department of SibFU", 3));
            Departments.Add(new InformDepartment("Informational Department of SibFU", 4));

            List<Person> CandidatesData = new List<Person> {
                new Person("John Doe", 30, Specialities.Programmer, 4.8),
                new Person("Jane Smith", 35, Specialities.Electrician, 4.5),
                new Person("Michael Johnson", 28, Specialities.Mechanic, 4.2),
                new Person("Sara Brown", 40, Specialities.Lawyer, 4.7),
                new Person("David Lee", 33, Specialities.Programmer, 4.9),
                new Person("Amy Chen", 29, Specialities.Mathematician, 4.4),
                new Person("Mark Davis", 36, Specialities.Mechanic, 4.6),
                new Person("Sophia Kim", 32, Specialities.Electrician, 4.8),
                new Person("Daniel Evans", 27, Specialities.Programmer, 4.3),
                new Person("Olivia Carter", 31, Specialities.Lawyer, 4.9)
            };
            CandidatesData.ForEach((Person candidate) => Candidates.Add(candidate));

            Departments.ForEach((Department department) => {
                department.hireEligibleCandidates(Candidates);
                Console.WriteLine(department.Title);
                Console.WriteLine("Employees:");
                department.Employees.ForEach((Person employee) => Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Speciality: {employee.Speciality}, Score: {employee.Score}"));
                Console.WriteLine("Left candidates:");
                Candidates.ForEach((Person candidate) => Console.WriteLine($"Name: {candidate.Name}, Age: {candidate.Age}, Speciality: {candidate.Speciality}, Score: {candidate.Score}"));
            });
        }
    }
}
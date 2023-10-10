using PersonNamespace;

namespace DepartmentNamespace
{
    public class Department
    {
        public string Title;
        public List<Person> Employees;
        public int NumberOfVacancies;

        public Department(string title, int numberOfVacancies)
        {
            Title = title;
            NumberOfVacancies = numberOfVacancies;
            Employees = new List<Person>();
        }

        public void hireEligibleCandidates(List<Person> candidates)
        {
            Employees = candidates.Where(candidateIsEligible).ToList();
            candidates.RemoveAll(candidateIsEligible);
            NumberOfVacancies -= Employees.Count;
        }

        protected virtual bool candidateIsEligible(Person candidate)
        {
            return candidate.Score >= 3.0;
        }
    }

    public class ElectricianDepartment : Department
    {
        public ElectricianDepartment(string title, int numberOfVacancies) : base(title, numberOfVacancies)
        {
        }

        protected override bool candidateIsEligible(Person candidate)
        {
            return candidate.Score >= 4.5 && candidate.Speciality == Specialities.Electrician;
        }
    }
    public class InformDepartment : Department
    {
        public InformDepartment(string title, int numberOfVacancies) : base(title, numberOfVacancies)
        {
        }

        protected override bool candidateIsEligible(Person candidate)
        {
            bool scoreIsEligible = candidate.Score >= 4.8;
            bool specialityIsEligible = candidate.Speciality == Specialities.Mathematician || candidate.Speciality == Specialities.Programmer;
            bool ageIsEligible = candidate.Age >= 22;
            
            return scoreIsEligible && specialityIsEligible && ageIsEligible;
        }
    }
    public class MechanicDepartment : Department
    {
        public MechanicDepartment(string title, int numberOfVacancies) : base(title, numberOfVacancies)
        {
        }

        protected override bool candidateIsEligible(Person candidate)
        {
            bool scoreIsEligible = candidate.Score >= 4.0;
            bool specialityIsEligible = candidate.Speciality == Specialities.Mechanic;
            bool ageIsEligible = candidate.Age <= 35;

            return scoreIsEligible && specialityIsEligible && ageIsEligible;
        }
    }
}
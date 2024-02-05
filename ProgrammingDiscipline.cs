using System;

internal class ProgrammingDiscipline : Discipline, IHavePractice
{
	public int PracticeCount { get; set; }

	public ProgrammingDiscipline(string Name, int PracticeCount) : base(Name)
	{
		this.PracticeCount = PracticeCount;
	}

	public override string Check(Student student)
	{
		if (student.Practices[this] >= PracticeCount)
			return string.Format($"{student.Name} успевает сдать все работы и получает автомат по программированию");
		else
			return string.Format($"{student.Name} не успевает сдать все работы и автомат по программированию не получит");
    }
}
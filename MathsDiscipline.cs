using System;

internal class MathsDiscipline : Discipline, IHaveFinalControl
{
    public int PassingScore { get; set; }

	public MathsDiscipline(string Name, int PassingScore) : base(Name)
	{
        this.PassingScore = PassingScore;
	}

    public override string Check(Student student)
    {
        if (student.FinalControl[this] >= PassingScore)
            return string.Format($"{student.Name} получает достаточный балл на итоговой аттестации и может рассчитывать на автомат по математическому анализу");
        else
            return string.Format($"{student.Name} не получает достаточный балл на итоговой аттестации и не может рассчитывать на автомат по математическому анализу");
    }
}
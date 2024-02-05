using System;

internal class ORGDiscipline : Discipline, IHaveAngryTeacher
{
	public ORGDiscipline(string Name) : base(Name)
	{
	}

    public override string Check(Student student)
    {
        return "Этот препод не даёт автоматов!";
    }
}
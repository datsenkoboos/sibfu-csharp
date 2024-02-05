using System;

internal abstract class Discipline
{
	public string Name;

	public Discipline(string Name)
	{
		this.Name = Name;
	}

	public abstract string Check(Student student);
}
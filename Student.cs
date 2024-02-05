using System;
internal class Student
{
	public string Name;
	public Dictionary<Discipline, int> Practices;
	public Dictionary<Discipline, int> FinalControl;

    public Student(string Name)
	{
		this.Name = Name;
		this.Practices = new Dictionary<Discipline, int>();
		this.FinalControl = new Dictionary<Discipline, int>();
	}
}
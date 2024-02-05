ProgrammingDiscipline pd = new ProgrammingDiscipline("Программирование", 10);
HistoryDiscipline hd = new HistoryDiscipline("История", 4, 80);
MathsDiscipline md = new MathsDiscipline("Математика", 75);
ORGDiscipline od = new ORGDiscipline("ОРГ");

List<Discipline> disciplines = new List<Discipline>
{
    pd, hd, md, od
};

Student student1 = new Student("George");
student1.Practices.Add(pd, 10);
student1.Practices.Add(hd, 5);
student1.FinalControl.Add(hd, 82);
student1.FinalControl.Add(md, 80);

Student student2 = new Student("Jaden");
student2.Practices.Add(pd, 8);
student2.Practices.Add(hd, 3);
student2.FinalControl.Add(hd, 85);
student2.FinalControl.Add(md, 75);

Student student3 = new Student("Bill");
student3.Practices.Add(pd, 8);
student3.Practices.Add(hd, 4);
student3.FinalControl.Add(hd, 72);
student3.FinalControl.Add(md, 68);

Student student4 = new Student("Max");
student4.Practices.Add(pd, 10);
student4.Practices.Add(hd, 2);
student4.FinalControl.Add(hd, 75);
student4.FinalControl.Add(md, 70);

List<Student> students = new List<Student>
{
    student1, student2, student3, student4
};

foreach(Discipline dist in disciplines)
{
    Console.WriteLine(dist.Name);
    Console.WriteLine("---------");
    foreach(Student stud in students)
    {
        string res = dist.Check(stud);
        if (res == od.Check(student1))
        {
            Console.WriteLine(res);
            break;
        }
        Console.WriteLine(res);
    }
    Console.WriteLine();
}
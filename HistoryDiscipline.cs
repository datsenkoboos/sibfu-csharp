using System;

internal class HistoryDiscipline : Discipline, IHavePractice, IHaveFinalControl
{
    public int PracticeCount { get; set; }
    public int PassingScore { get; set; }

    public HistoryDiscipline(string Name, int PracticeCount, int PassingScore) : base(Name)
	{
        this.PracticeCount = PracticeCount;
        this.PassingScore = PassingScore;
	}

    public override string Check(Student student)
    {
        if (student.Practices[this] >= PracticeCount && student.FinalControl[this] >= PassingScore)
            return string.Format($"{student.Name} успевает сдать все работы и получает достаточный балл на итоговой аттестации и может рассчитывать на автомат по истории");
        else if (student.Practices[this] >= PracticeCount)
            return string.Format($"{student.Name} успевает сдать все работы и не получает достаточный балл на итоговой аттестации и не может рассчитывать на автомат по истории");
        else if (student.FinalControl[this] >= PassingScore)
            return string.Format($"{student.Name} не успевает сдать все работы и получает достаточный балл на итоговой аттестации и не может рассчитывать на автомат по истории");
        else
            return string.Format($"{student.Name} не успевает сдать все работы и не получает достаточный балл на итоговой аттестации и не может рассчитывать на автомат по истории");
    }
}
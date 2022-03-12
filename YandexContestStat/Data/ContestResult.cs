namespace YandexContestStat.Data
{
    public class ContestResult
    {
        public int ContestNumber { get; set; }
        public string Student { get; set; }
        public string StudentGroup{ get; set; }
        public int TasksCompleted { get; set; }
        public int TasksCount { get; set; }

        public ContestResult(int contestNumber, string studentName, string studentGroup, int score, int tasksCount)
        {
            ContestNumber = contestNumber;
            Student = studentName;
            StudentGroup = studentGroup;
            TasksCompleted = score;
            TasksCount = tasksCount;
        }
    }
}

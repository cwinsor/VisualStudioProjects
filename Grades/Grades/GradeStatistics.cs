namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            LowestGrade = double.MaxValue;
            HighestGrade = double.MinValue;
            AverageGrade = 0;
        }
        public double LowestGrade;
        public double AverageGrade;
        public double HighestGrade;
    }
}
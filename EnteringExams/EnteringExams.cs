namespace EnteringExams
{
    public class Exam
    {
        public string Subject { get; set; }
        public int PassScore { get; set; }

        public Exam(string subject, int pass_score)
        {
            Subject = subject;
            PassScore = pass_score;
        }
        public override string ToString()
        {
            return $"{Subject}: {PassScore}";
        }
    }

    public class University
    {
        Exam? exam { get; set; }
        
        public void SetExam(Exam exam)
        {
            this.exam = exam;
        }
        public void TryExam(int score)
        {
            if (score >= exam?.PassScore)
            {
                Console.WriteLine($"You passed the exam in {exam?.Subject}");
            }
            else
            {
                Console.WriteLine($"You failed the exam in {exam?.Subject}");
            }
        }

    }
}

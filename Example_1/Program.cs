using System;
using Payments;
using EnteringExams;
using Calculator;

namespace Example_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Payment payment = new Payment(100, "Na chipsiki");
            Bank bank = new Bank();
            bank.doPayment(payment);
            payment.showInfo();*/

            /*Exam exam1 = new Exam("Math", 70);
            Exam exam2 = new Exam("English", 60);
            University university = new University();
            university.SetExam(exam1);
            university.TryExam(75);
            university.SetExam(exam2);
            university.TryExam(10);
            university.SetExam(exam2);
            university.TryExam(80);*/

            LogCalculator logCalculator = new LogCalculator();
            float output = 0;
            logCalculator.calcLog(ref output, 10);

            Console.WriteLine($"Log(10) = {output}");

            logCalculator.sumLogs(ref output, 10, 100);
            Console.WriteLine($"Log(10 * 100) = {output}");

            logCalculator.substractLogs(ref output, 100, 10);
            Console.WriteLine($"Log(100 / 10) = {output}");

            logCalculator.calcLogXY(ref output, 10, 2);
            Console.WriteLine($"Log(10, 2) = {output}");

        }
    }
}

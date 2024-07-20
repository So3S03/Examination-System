using Eamination_System.SubjectDesign;
using System.Diagnostics;

namespace Eamination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SubId = 0;
            string SubName;
            bool Flag = false;
            do
            {
                Console.Write("Please Enter Subject ID : ");
                Flag = int.TryParse(Console.ReadLine(), out SubId);
            } while (!Flag || SubId == 0);
            Console.Write("Please Enter Subject Name : ");
            SubName = Console.ReadLine() ?? string.Empty;
            Subject Sub = new Subject(SubId,SubName);
            Sub.CreateExam();

            Console.Clear();

            Console.Write("Do You Want To Start The Exam ( y | n ) : ");
            char UserChoose = 'n';
            char.TryParse(Console.ReadLine()?.ToLower(), out UserChoose);
            if (UserChoose == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                Sub.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }


        }
    }
}

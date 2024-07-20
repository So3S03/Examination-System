using Eamination_System.ExamDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.SubjectDesign
{
    internal class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int SubId, string SubName)
        {
            this.SubId = SubId;
            this.SubName = SubName;
        }
        public void CreateExam()
        {
            bool Flag = false;
            int ExamType = 0;
            int ExamTime = 0;
            int QNum = 0;
            do
            {
                Console.Write("Please Enter The Type Of Exam You Want To Create : ( 1 For Practical | 2 For Final ) : ");
                Flag = int.TryParse(Console.ReadLine(), out ExamType);
            } while (!Flag || ExamType < 1 || ExamType > 2);

            Flag = false;

            do
            {
                Console.Write("Please Enter Exam Evaluation in Minutes : ");
                Flag = int.TryParse(Console.ReadLine(), out ExamTime);
            } while (!Flag || ExamTime < 0);

            do
            {
                Console.Write("Please Enter Questions Number : ");
                Flag = int.TryParse(Console.ReadLine(), out QNum);
            } while (!Flag);

            if (ExamType == 1)
            {
                Exam = new PracticalExam(ExamTime, QNum);
                Exam.CreateExam();
            }
            else
            { 
                Exam = new FinalExam(ExamTime, QNum);
                Exam.CreateExam();
            }
        }

    }
}

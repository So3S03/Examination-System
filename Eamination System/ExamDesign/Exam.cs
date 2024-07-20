using Eamination_System.QuestionDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.ExamDesign
{
    internal abstract class Exam
    {
        public int ExamTime { get; set; }
        public int QNumber { get; set; }
        public Question[] Questions { get; set; }
        public Exam(int ExamTime, int QNumber)
        {
            this.ExamTime = ExamTime;
            this.QNumber = QNumber;
            Questions = new Question[QNumber];
        }
        public abstract void CreateExam();
        public abstract void ShowExam();
    }
}

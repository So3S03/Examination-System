using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.QuestionDesign
{
    internal abstract class Question
    {
        public abstract string QHeader { get;}
        public string QBody { get; set; }
        public int QMark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        public Question()
        {
            RightAnswer = new Answer();
        }

        public abstract void ExaminarQuestion();

        public override string ToString()
        {
            return $"QuestionHeader : {QHeader} \t Mark:{QMark} \n{QBody} ";
        }
    }
}

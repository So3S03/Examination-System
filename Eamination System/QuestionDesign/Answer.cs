using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.QuestionDesign
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer()
        {
            
        }

        public override string ToString()
        {
            return $"Answer: {AnswerId}. {AnswerText}";
        }
    }
}

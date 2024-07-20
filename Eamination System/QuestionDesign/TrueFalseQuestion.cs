using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.QuestionDesign
{
    internal class TrueFalseQuestion : Question
    {
        public override string QHeader { get { return "Choose Between True Or False"; } }

        public TrueFalseQuestion()
        {
            AnswerList = new Answer[2];
        }
        public override void ExaminarQuestion()
        {
            Console.WriteLine($"Question: {QHeader}");
            Console.WriteLine("========================================");
            Console.Write("Please Enter The Question Body: ");
            QBody = Console.ReadLine() ?? "No Question Has Been Enterd";
            Console.WriteLine();
            Console.WriteLine("=========================================");
            bool Flag = false;
            int Mark;
            do
            {
                Console.Write("Please Enter Question Mark : ");
                Flag = int.TryParse(Console.ReadLine(), out Mark);

            } while (!Flag || Mark < 0);
            QMark = Mark;
            Console.WriteLine();
            Console.WriteLine("==========================================");
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer();
            AnswerList[0].AnswerId = 1;
            AnswerList[0].AnswerText = "True";
            AnswerList[1] = new Answer();
            AnswerList[1].AnswerId = 2;
            AnswerList[1].AnswerText = "False";
            Flag = false;
            int AnsId = 0;
            do
            {
                Console.Write("Please Enter The ID Of The Right Answer ( 1 For True | 2 For False): ");
                Flag = int.TryParse(Console.ReadLine(), out AnsId);

                if (Flag && AnsId > 0 && AnsId <= AnswerList.Length)
                {
                    for (int i = 0; i < AnswerList.Length; i++)
                    {
                        if (AnswerList[i].AnswerId == AnsId)
                        {
                            RightAnswer = new Answer();
                            RightAnswer.AnswerId = AnsId;
                            RightAnswer.AnswerText = AnswerList[i].AnswerText;
                            Console.WriteLine();
                            Console.WriteLine($"Right Answer is : {RightAnswer.AnswerId}. {RightAnswer.AnswerText}");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID. Please enter a valid Answer ID.");
                    Flag = false;
                }
            } while (!Flag || AnsId <= 0);


        }
    }
}

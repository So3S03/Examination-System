using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.QuestionDesign
{
    internal class MCQQuestion : Question
    {
        public int AnswerNumber { get; set; }
        public override string QHeader { get { return "Choose Only One Answer"; } }

        public MCQQuestion()
        {
            AnswerList = new Answer[AnswerNumber];
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
            Flag = false;
            int AnsNum = 0;
            do
            {
                Console.Write("Please Enter Answers Number : ");
                Flag = int.TryParse(Console.ReadLine(), out AnsNum);
            } while (!Flag || AnsNum <= 0);
            Console.WriteLine();
            AnswerList = new Answer[AnsNum];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.Write($"Please Enter Answer {i + 1} : ");
                AnswerList[i] = new Answer();
                AnswerList[i].AnswerId = (i + 1);
                AnswerList[i].AnswerText = Console.ReadLine() ?? "No Answer Has Been Enterd";
            }
            Console.WriteLine();
            Console.WriteLine("================================================");
            Flag = false;
            int AnsId = 0;
            do
            {
                Console.Write("Please Enter The ID Of The Right Answer: ");
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

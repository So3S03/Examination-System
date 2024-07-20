using Eamination_System.QuestionDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamination_System.ExamDesign
{
    internal class FinalExam : Exam
    {
        public FinalExam(int ExamTime, int QNumber) : base(ExamTime, QNumber)
        {
        }

        public override void CreateExam()
        {
            bool Flag = false;
            int QType = 0;
            for (int i = 0; i < QNumber; i++)
            {
                do
                {
                    Console.Write($"Please Enter Type Of Question {i + 1} [ 1 For MCQ | 2 For TrueFalse] : ");
                    Flag = int.TryParse(Console.ReadLine(), out QType);

                } while (!Flag || QType < 1 || QType > 2);

                if (QType == 1)
                {
                    Questions[i] = new MCQQuestion();
                    Questions[i].ExaminarQuestion();
                }
                else
                {

                    Questions[i] = new TrueFalseQuestion();
                    Questions[i].ExaminarQuestion();

                }
            }
            Console.WriteLine();
        }

        public override void ShowExam()
        {
            bool Flag = false;
            int Ans = 0;
            int FullMark = 0;
            int ExamFinalMark = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                do
                {
                    Console.WriteLine(Questions[i].ToString());
                    for (int j = 0; j < Questions[i].AnswerList.Length; j++)
                    {
                        Console.Write($"{Questions[i].AnswerList[j]} \n");
                    }
                    Console.WriteLine();
                    Console.WriteLine("=========================================");
                    Console.Write("Please Enter The ID Of The Solution : ");
                    Flag = int.TryParse(Console.ReadLine(), out Ans);

                    if (Flag && Ans > 0 && Ans <= Questions[i].AnswerList.Length)
                    {
                        if (Ans == Questions[i].RightAnswer.AnswerId)
                        {
                            FullMark += Questions[i].QMark;
                        }
                    }
                    else
                    {
                        Flag = false;
                    }

                } while (!Flag);
            }

            Console.Clear();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"{Questions[i]}");
                Console.WriteLine($"Right Answer is : ID = {Questions[i].RightAnswer.AnswerId}, Answer Text = {Questions[i].RightAnswer.AnswerText}");
                ExamFinalMark += Questions[i].QMark;
            }

            Console.WriteLine($" Your Exam Mark is {FullMark} / {ExamFinalMark}");
        }
    }

}

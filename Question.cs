using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question
    {
        public string QuestionData { get; set; }
        public string CorrectAnswer { get; set; }
        public string QuestionChoice { get; set; }

        public static List<string> Answers { get; set; } = new List<string>();


        public static void MakeQuestion(int number)
        {
            while (number > 0)
            {
                Console.WriteLine("  Enter the question data");
                string Questiondata = Console.ReadLine();

                Console.WriteLine("  Enter the question Choices");
                string Questionchoice = Console.ReadLine();

                Console.WriteLine("  Enter the answer");
                string Questionanswer = Console.ReadLine();

                Answers.Add(Questionanswer);


                Exam.questions.Add(new Question() { QuestionData = Questiondata, QuestionChoice = Questionchoice, CorrectAnswer = Questionanswer });

                number--;
            }

        }

        public static void  Calculatemarks()
        {
            int Marks = 0;
            Console.WriteLine($"The exam consist of : {Answers.Count} Questions");
            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i] == Exam.answers[i])
                {
                   
                    Marks++;

                }
            }
            Console.WriteLine($"Your marks is {Marks}");
        }
    }

}


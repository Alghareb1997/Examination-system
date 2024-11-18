using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam
    {
        public string QuestionData { get; set; }
        public string CorrectAnswer { get; set; }
        public string QuestionChoice { get; set; }



        public static List<Question> questions = new List<Question>();
        public  static List<string> answers = new List<string>();
        private int Question_Counter = 0;

        
        public void DisplayExam()
        {
            foreach (var item in questions)
            {
                Console.WriteLine(item.QuestionData);
                Console.WriteLine(item.QuestionChoice);
                Console.WriteLine(" Entre your answer Please .....");
                string Answer = Console.ReadLine();
                answers.Add(Answer);



            }


        }
        public  void Addquestion(Question question)
        {
            questions.Add(question);
            Question_Counter++;
            Console.WriteLine("Succes adding");
        }
        public int Counter()
        {
            {
                return Question_Counter;
            }
        }

    }
}

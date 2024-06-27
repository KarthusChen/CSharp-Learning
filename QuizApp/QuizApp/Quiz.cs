using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions =questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("欢迎来到你还爱不爱我quiz!");
            int questionNumber = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserInput();
                if (question.isCorrectAnswer(userChoice)) 
                {
                    Console.WriteLine("对咯！");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"你不爱我了,应该是{question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResult();
        }

        private void DisplayResult()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║            Result            ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine($"考完啦，总分{_score}/{_questions.Length}分");
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║           Question           ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }

        }

        private int GetUserInput()
        {
            Console.Write("用数字写一下答案:");
            string input=Console.ReadLine();
            int choice = 0;
            while(!int.TryParse(input,out choice)||choice>4||choice<1)
            {
                Console.WriteLine("用数字呀！！！\n","再来一遍");
                input = Console.ReadLine();
            }
            return choice-1;
        }

    }
}

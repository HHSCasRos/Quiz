using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> quiz = new List<Question>()
            {
                new Question(){Text = "Who was the inventor of Java?", Answer = "James Gosling", Difficulty = 3, Category = "Java"},
                new Question(){Text = "What is 18 / 3?", Answer = "6", Difficulty = 1, Category = "Math"},
                new Question(){Text = "What is Java", Answer = "A programming language", Difficulty = 1, Category = "Java"},
                new Question(){Text = "What is LOIC?", Answer = "It's a infamous hacking tool", Difficulty = 2, Category = "Hacking"},
                new MultipleChoiseQuestion(){Text = "how old is Bob if he's born on the 12th of feburary 1996", Answer = "C", Difficulty = 1, Category = "Math", Options = { "A: 19", "B: 20", "C: 21", "D: 22", "E: 23" } }
            };

            var sortedQuiz = quiz.OrderBy(q => q.Difficulty);

            foreach (Question q in sortedQuiz)
            {
                presentQuestion(q);
            }

            List<Question> easyQuiz = quiz.Where( q => q.Difficulty == 1 ).ToList();

            foreach (Question q in easyQuiz)
            {
                presentQuestion(q);
            }

            Console.ReadKey();
        }

        public static void presentQuestion(Question q)
        {
            q.Display();
            Console.Write("Your awnser: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.CheckAnswer(response));
        }
    }
}

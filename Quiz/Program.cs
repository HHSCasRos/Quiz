using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question first = new Question()
            {
                Text = "Who was the inventor of Java?",
                Answer = "James Gosling"
            };

            presentQuestion(first);

            Console.ReadKey();
        }

        public static void presentQuestion(Question q)
        {
            q.display();
            Console.Write("Your awnser: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(response));
        }
    }
}

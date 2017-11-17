using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question first = new Question();
            first.setText("Who was the inventor of Java?");
            first.setAnswer("James Gosling");

            presentQuestion(first);



            

            

            Console.WriteLine("Hello World!");
        }

        public static void presentQuestion(Question q)
        {
            q.display();
            Console.WriteLine("Your awnser: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(response));
        }
    }
}

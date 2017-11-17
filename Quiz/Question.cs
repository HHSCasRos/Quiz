using System;

namespace Quiz
{
    internal class Question
    {
        private string text;
        private string answer;

        public string Answer { set => answer = value; }
        public string Text { set => text = value; }

        internal void display()
        {
            Console.WriteLine(this.text);
        }

        internal bool checkAnswer(string response)
        {
            return this.answer == response;
        }
    }
}
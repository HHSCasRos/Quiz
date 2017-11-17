using System;

namespace Quiz
{
    internal class Question
    {
        private string text;
        private string answer;
        private int difficulty;
        private string category;

        public string Answer { set => answer = value; }
        public string Text { set => text = value; }
        public int Difficulty { get => difficulty;  set => difficulty = value; }
        public string Category { set => category = value; }

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
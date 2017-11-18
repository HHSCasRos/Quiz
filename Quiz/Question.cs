using System;

namespace Quiz
{
    internal class Question
    {
        private string text;
        private string answer;
        private int difficulty;
        private string category;

        public string Answer { get => answer; set => answer = value; }
        public string Text { get => text; set => text = value; }
        public int Difficulty { get => difficulty;  set => difficulty = value; }
        public string Category { set => category = value; }

        internal void Display()
        {
            Console.WriteLine(this.text);
        }

        internal bool CheckAnswer(string response)
        {
            return this.answer == response;
        }
    }
}
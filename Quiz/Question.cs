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
            throw new NotImplementedException();
        }

        internal bool checkAnswer(string response)
        {
            throw new NotImplementedException();
        }
    }
}
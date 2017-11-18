using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class MultipleChoiseQuestion : Question
    {
        private List<string> options = new List<string>();

        public List<string> Options { get => options; set => options = value; }

        internal new void Display()
        {
            Console.WriteLine(this.Text);
            for (int i = 1; i <= options.Count; i++)
            {
                Console.WriteLine(i + ": " + options[i - 1]);
            }
        }
        
        internal new bool CheckAnswer(string response)
        {
            return this.Answer == response;
        }
    }
}

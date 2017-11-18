using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class MultipleChoiseQuestion : Question
    {
        private List<string> options = new List<string>();

        public List<string> Options { get => options; set => options = value; }

        internal override void Display()
        {
            Console.WriteLine(this.Text);
            foreach(string o in options)
            {
                Console.WriteLine(o);
            }
        }
        
        internal override bool CheckAnswer(string response)
        {
            foreach (string o in options)
            {
                if (response.Substring(0, 1) == o.Substring(0, 1))
                {
                    return o.Substring(0, 1) == this.Answer;
                }
            }
            return false;
        }
    }
}

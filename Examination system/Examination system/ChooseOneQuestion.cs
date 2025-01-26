using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class ChooseOneQuestion:Question
    {
        public List<string> Options { get; set; }
        //public int CorrectChoice {  get; set; }
        public ChooseOneQuestion(string header, string body, int mark,List<string>_options) : base(header, body,mark)
        {
            Options = _options;
        }
        public override void Display()
        {
            Console.WriteLine($"[Choose one] {Header}:{Body}");
            //for(int i=0; i<Options.Count; i++)
            //{
            //    Console.WriteLine($"{i+1}){Options[i]}");
            //}
        }
    }
}

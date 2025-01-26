using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class TorFQuestion:Question
    {
        //public bool CorrectAns;
        public override void Display()
        {
            Console.WriteLine($"[True or False] {Header}:{Body}");
        }
        public TorFQuestion(string _header, string _body,int _mark) : base(_header, _body, _mark)
        {
            
        }
    }
}

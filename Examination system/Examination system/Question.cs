using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class Question
    {
        public string Body {  get; set; }
        public int Mark {  get; set; }
        public string Header {  get; set; }

        public Question(string _header,string _body,int _mark)
        {
            Body=_body;
            Mark=_mark;
            Header=_header;
        }
        public abstract void Display();
        public override string ToString()
        {
            return $"Header:{Header}, Body{Body}, Mark:{Mark}";
        }
    }
}

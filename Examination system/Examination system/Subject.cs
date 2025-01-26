using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Subject
    {
        public string SubjectName {  get; set; }
        public Subject(string _subjectName="")
        {
            SubjectName= _subjectName;
        }
    }
}

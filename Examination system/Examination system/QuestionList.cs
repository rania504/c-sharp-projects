using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class QuestionList:List<Question>
    {
        string saveFile;
        public QuestionList(string _saveFile)
        {
            saveFile = _saveFile;
        }
        public new void Add(Question question)
        {
            base.Add(question);
            using (StreamWriter writer = new StreamWriter(saveFile, true))
            {
                writer.WriteLine($"Question:{question.Header}");
                writer.WriteLine($"Body:{question.Body}");
                writer.WriteLine($"Mark:{question.Mark}");
                if (question is ChooseOneQuestion chooseOne)
                {
                    //Console.WriteLine("options:");
                    foreach (var option in chooseOne.Options)
                    {
                        writer.WriteLine("-" + option);
                    }
                }
                else if (question is ChooseAllQuestion chooseAll)
                {
                    //Console.WriteLine("options:");
                    foreach (var option in chooseAll.Options)
                    {
                        writer.WriteLine("-" + option);
                    }
                }
                writer.WriteLine();
            }

        }
        //private void SaveQuestion(Question question)
        //{
        //    using (StreamWriter writer = new StreamWriter(saveFile, true))
        //    {
        //        writer.WriteLine(question);
        //    }
        //}
        //public void SaveStudentAnswer(Question question, string answer)
        //{
        //    using (StreamWriter writer = new StreamWriter(saveFile, true))
        //    {
        //        writer.WriteLine($"student answer for {question.Header} is {answer}");
        //        writer.WriteLine();
        //    }
        //}
    }
}

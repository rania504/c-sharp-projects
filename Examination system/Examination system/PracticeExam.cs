using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class PracticeExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine($"{Title}");
            foreach(var d in QSdictionary)
            {
                d.Key.Display();
                for (int i = 0; i < d.Value.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {d.Value[i].text}");
                }
                Console.Write("Your Answer: ");
                string studentAnswer = Console.ReadLine();
                SaveStudentAnswer(d.Key, studentAnswer);
                Console.Write("right answer is: ");
                foreach (var answer in d.Value)
                {
                    if (answer.IsCorrect)
                    {
                        Console.WriteLine(answer.text);
                        
                    }
                    
                }
            }
        }
    }
}

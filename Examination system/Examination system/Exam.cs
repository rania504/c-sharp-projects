using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class Exam:ICloneable,IComparable<Exam>
    {
        public string Title {  get; set; }
        public double Time {  get; set; }
        public int NumOfQuestion { get; set; }
        public Dictionary<Question, AnswerList> QSdictionary { get; set; } = new();
        public Subject Subject { get; set; }
        public string Mode { get; private set; } = "Queued";
        public SubjectNotification Notification { get; set; }

        public void StartExam()
        {
            Mode = "Starting";
            Notification?.NotifyStudents($"The exam {Title} for {Subject.SubjectName} is starting.");
        }
        public void Finsh()
        {
            Mode = "finsh";
            Notification?.NotifyStudents($"The exam {Title} for {Subject.SubjectName} is finshed.");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam? other)
        {
            return Title.CompareTo(other.Title);
        }

        public abstract void ShowExam();
        public override string ToString()
        {
            return $"exam:{Title}, time:{Time},number of questions:{NumOfQuestion}, subject:{Subject}";
        }
        protected void SaveStudentAnswer(Question question, string answer)
        {
            string file = $"{Title}.txt";
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine($"student answer for {question.Header} is {answer}");
                writer.WriteLine();
            }
        }

    }
}

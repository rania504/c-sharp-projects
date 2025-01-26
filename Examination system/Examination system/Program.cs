namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notification = new SubjectNotification();
            Subject subject = new Subject() { SubjectName = "Computer Science" };
            Student s1 = new Student() { Name = "ahmed" };
            Student s2 = new Student() { Name = "sara" };

            QuestionList ql1 = new QuestionList("practice_eaxm.txt");
            QuestionList ql2 = new QuestionList("final_eaxm.txt");

            Question q1 = new TorFQuestion("Q1", "c# is a programming language?", 5);
            AnswerList TFanswer = new AnswerList() { new Answer { text = "true", IsCorrect = true }, new Answer { text = "false", IsCorrect = false } };
            Question q2 = new ChooseOneQuestion("Q2", "Whic of the correct answer for 1+1 [binary system]?", 5, ["5","10","2","7"]);
            AnswerList COanswer = new AnswerList()
            {
                new Answer { text="5",IsCorrect=false},
                new Answer { text="10",IsCorrect=true},
                new Answer { text="2",IsCorrect=false},
                new Answer { text="7",IsCorrect=false},
            };
            Question q3 = new ChooseAllQuestion("Q3", "Which of the following is programming lang", 10, ["c#","English","c++","French"]);
            AnswerList CAanswer = new AnswerList()
            {
                new Answer { text="c#",IsCorrect=true},
                new Answer { text="English",IsCorrect=false},
                new Answer { text="c++",IsCorrect=true},
                new Answer { text="French",IsCorrect=false},
            };
            ql1.Add(q1);
            ql1.Add(q2);
            ql1.Add(q3);

            ql2.Add(q3);
            ql2.Add(q1);
            ql2.Add(q2);

            notification.OnNotify += s1.Notify;
            notification.OnNotify += s2.Notify;

            PracticeExam p1 = new PracticeExam() { Title = "practice exam1", NumOfQuestion = 3, Time = 30, Subject = subject, Notification = notification };
            p1.QSdictionary.Add(q1, TFanswer);
            p1.QSdictionary.Add(q2, COanswer);
            p1.QSdictionary.Add(q3, CAanswer);
            FinalExam f1 = new FinalExam() { Title="final exam1",NumOfQuestion=3,Time=30,Subject=subject,Notification=notification};
            f1.QSdictionary.Add(q2, COanswer);
            f1.QSdictionary.Add(q3, CAanswer);
            f1.QSdictionary.Add(q1, TFanswer);

            Console.WriteLine("Select Exam Type: 1-Practice 2-Final");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                p1.StartExam();
                p1.ShowExam();
                p1.Finsh();
            }
            else if (choice == 2)
            {
                f1.StartExam();
                f1.ShowExam();
                f1.Finsh();
            }
            
        }
    }
}

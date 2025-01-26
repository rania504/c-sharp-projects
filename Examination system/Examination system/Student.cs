using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Student
    {
        public string Name { get; set; }

        public void Notify(string message)
        {
            Console.WriteLine($"Notification for {Name}: {message}");
        }
    }
}

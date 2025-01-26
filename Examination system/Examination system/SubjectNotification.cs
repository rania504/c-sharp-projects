using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class SubjectNotification
    {
        public event Action<string> OnNotify;

        public void NotifyStudents(string message)
        {
            OnNotify?.Invoke(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Doc_Assist : Doctor
    {
        public void _DoctorAssistant()
        {
            Console.WriteLine();
        }
        public short AssistantAge { get; set; }
        public Doc_Assist()
        {

        }
    }
}

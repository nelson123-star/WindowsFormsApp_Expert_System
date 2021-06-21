using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Expert_System
{
    class ExpertSystemAnswer
    {
        public int Wigth;  
        public string Text;

    }
    class ExpertSystemQuestion
    {
        public string QuestionText;
        public ExpertSystemAnswer AnswerOne;
        public ExpertSystemAnswer AnswerTwo;

        public int Answer;

        public ExpertSystemQuestion()
        {
            AnswerOne = new ExpertSystemAnswer();
            AnswerTwo = new ExpertSystemAnswer();
        }
        public int CheckedAnswerWigth()
        {
            int AnswerWigth = 0;

            switch(Answer)
            { 
                case 1: AnswerWigth = AnswerOne.Wigth; break;
                case 2: AnswerWigth = AnswerTwo.Wigth; break;                
            }
            return AnswerWigth;
        }
    }
}

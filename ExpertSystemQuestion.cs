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
        public ExpertSystemAnswer AnswerThree;

        public int Answer;

        public ExpertSystemQuestion()
        {
            AnswerOne = new ExpertSystemAnswer();
            AnswerTwo = new ExpertSystemAnswer();
            AnswerThree = new ExpertSystemAnswer();
        }
        public int CheckedAnswerWigth()
        {
            int AnswerWigth = 0;

            switch(Answer)
            { 
                case 1: AnswerWigth = AnswerOne.Wigth; break;
                case 2: AnswerWigth = AnswerTwo.Wigth; break;
                case 3: AnswerWigth = AnswerThree.Wigth; break;
                
            }
            return AnswerWigth;
        }
    }
}

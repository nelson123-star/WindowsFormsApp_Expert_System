using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Reflection;

namespace WindowsFormsApp_Expert_System
{
    public partial class ExpertSystemForm : Form
    {
        //private ExpertSystemCore Core;
        List<Human> List;
        List<ExpertSystemQuestion> QuestionListKnowledge;
        List<ExpertSystemQuestion> QuestionListImproving;
        List<ExpertSystemQuestion> QuestionListCommunication;
        List<ExpertSystemQuestion> QuestionListJobInteresting;
        List<ExpertSystemQuestion> QuestionListResponsible;
        List<ExpertSystemQuestion> QuestionListPoryadochnost;
        public double[] inputs;

        public int Number = 0; 
        public int Number2 = 0;
        public string txt = "";


        public ExpertSystemForm()
        {
            InitializeComponent();

            //for (int i = 1; i < 3; i++)
            //{
            //    var RadioButton = CreateRadioButton(i);
            //    Controls.Add(RadioButton);
            //}

            foreach (var list in Program.HumanList) txt = $"{list.profession}.txt"; 
            
            List = new List<Human>();
            QuestionListKnowledge = new List<ExpertSystemQuestion>();
            QuestionListImproving = new List<ExpertSystemQuestion>();
            QuestionListCommunication = new List<ExpertSystemQuestion>();
            QuestionListJobInteresting = new List<ExpertSystemQuestion>();
            QuestionListCommunication = new List<ExpertSystemQuestion>();
            QuestionListResponsible = new List<ExpertSystemQuestion>();
            QuestionListPoryadochnost = new List<ExpertSystemQuestion>();

            //Question("Junior C#.txt", QuestionListKnowledge);
            Question(txt, QuestionListKnowledge);
            WriteQuestion(Number2, QuestionListKnowledge);
            Question("порядочность.txt", QuestionListPoryadochnost);
            WriteQuestion(Number2, QuestionListPoryadochnost);
            Question("обучаемость.txt", QuestionListImproving);
            WriteQuestion(Number2, QuestionListImproving);
            Question("коммуникабельность.txt", QuestionListCommunication);
            WriteQuestion(Number2, QuestionListCommunication);
            Question("заинтересованность.txt", QuestionListJobInteresting);
            WriteQuestion(Number2, QuestionListJobInteresting);
            Question("ответственность.txt", QuestionListResponsible);
            WriteQuestion(Number2, QuestionListResponsible);
            func(Number);
        }
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            //Checked - Возвращает или задает значение, указывающее, выбран ли данный элемент управления.
            Number++;
            func(Number);
        }
        private void func(int number1)
        {
            if (number1 < QuestionListPoryadochnost.Count)
            {
                WriteQuestion(Number, QuestionListPoryadochnost);
                if (radioButton1.Checked) QuestionListPoryadochnost[number1].Answer = 1;
                else if (radioButton2.Checked) QuestionListPoryadochnost[number1].Answer = 2;
            }
            else if (number1 >= QuestionListPoryadochnost.Count && number1 < QuestionListPoryadochnost.Count + QuestionListKnowledge.Count)
            {
                Number2 = Number - QuestionListPoryadochnost.Count;
                WriteQuestion(Number2, QuestionListKnowledge);
                if (radioButton1.Checked) QuestionListKnowledge[Number2].Answer = 1;
                else if (radioButton2.Checked) QuestionListKnowledge[Number2].Answer = 2;
            }
            else if (Number >= QuestionListPoryadochnost.Count + QuestionListKnowledge.Count && Number < QuestionListPoryadochnost.Count + QuestionListKnowledge.Count + QuestionListImproving.Count)
            {
                Number2 = Number - (QuestionListPoryadochnost.Count + QuestionListKnowledge.Count);
                WriteQuestion(Number2, QuestionListImproving);
                if (radioButton1.Checked) QuestionListImproving[Number2].Answer = 1;
                else if (radioButton2.Checked) QuestionListImproving[Number2].Answer = 2;
            }
            else if (Number >= QuestionListPoryadochnost.Count + QuestionListKnowledge.Count + QuestionListImproving.Count && Number < QuestionListPoryadochnost.Count + QuestionListCommunication.Count + +QuestionListKnowledge.Count + QuestionListImproving.Count)
            {
                Number2 = Number - (QuestionListPoryadochnost.Count + QuestionListKnowledge.Count + QuestionListImproving.Count);
                WriteQuestion(Number2, QuestionListCommunication);
                if (radioButton1.Checked) QuestionListCommunication[Number2].Answer = 1;
                else if (radioButton2.Checked) QuestionListCommunication[Number2].Answer = 2;

            }
            else if (Number >= QuestionListPoryadochnost.Count + QuestionListCommunication.Count + QuestionListKnowledge.Count + QuestionListImproving.Count && Number < QuestionListPoryadochnost.Count + QuestionListCommunication.Count + +QuestionListKnowledge.Count + QuestionListImproving.Count + QuestionListJobInteresting.Count)
            {
                Number2 = Number - (QuestionListPoryadochnost.Count + QuestionListCommunication.Count + QuestionListKnowledge.Count + QuestionListImproving.Count);
                WriteQuestion(Number2, QuestionListJobInteresting);
                if (radioButton1.Checked) QuestionListJobInteresting[Number2].Answer = 1;
                else if (radioButton2.Checked) QuestionListJobInteresting[Number2].Answer = 2;
            }
            else if (Number >= QuestionListPoryadochnost.Count + QuestionListCommunication.Count + QuestionListKnowledge.Count + QuestionListImproving.Count + QuestionListJobInteresting.Count && Number < QuestionListPoryadochnost.Count + QuestionListCommunication.Count + QuestionListKnowledge.Count + QuestionListImproving.Count + QuestionListJobInteresting.Count + QuestionListResponsible.Count)
            {
                Number2 = Number - (QuestionListPoryadochnost.Count + QuestionListCommunication.Count + QuestionListKnowledge.Count + QuestionListImproving.Count + QuestionListJobInteresting.Count);
                WriteQuestion(Number2, QuestionListResponsible);
                if (radioButton1.Checked) QuestionListResponsible[Number2].Answer = 1;
                else if (radioButton2.Checked) QuestionListResponsible[Number2].Answer = 2;
            }
            else if (Number >= QuestionListPoryadochnost.Count + QuestionListCommunication.Count + QuestionListKnowledge.Count + QuestionListImproving.Count + QuestionListJobInteresting.Count + QuestionListResponsible.Count)
            {
                Total(QuestionListPoryadochnost);
                Total(QuestionListKnowledge);
                Total(QuestionListImproving);
                Total(QuestionListCommunication);
                Total(QuestionListJobInteresting);
                Total(QuestionListResponsible);
                Output(Number);
            }
        }
        private void Output(int number)
        {
            using (StreamWriter streamWriter = new StreamWriter("human.xml", true, Encoding.UTF8))
            {
                foreach (var list in List)
                {
                    streamWriter.Write(list.poryadochnost);
                    streamWriter.Write(list.knowledge);
                    streamWriter.Write(list.improving);
                    streamWriter.Write(list.communication);
                    streamWriter.Write(list.jobInteresting);
                    streamWriter.Write(list.responsible);
                    streamWriter.Write("\n");
                }
            }
            Program.Output = true;
            this.Close();
        }

        private void Question(string sFileName, List<ExpertSystemQuestion> List)
        {
            //List = new List<ExpertSystemQuestion>();
            StreamReader textreader = new StreamReader(sFileName);
            while (!textreader.EndOfStream)
            {
                ExpertSystemQuestion question = new ExpertSystemQuestion();
                question.QuestionText = textreader.ReadLine();
                question.AnswerOne.Text = textreader.ReadLine();
                question.AnswerOne.Wigth = Convert.ToInt32(textreader.ReadLine()); 
                question.AnswerTwo.Text = textreader.ReadLine();
                question.AnswerTwo.Wigth = Convert.ToInt32(textreader.ReadLine());
                List.Add(question);
            }
            textreader.Close();
        }
        private void WriteQuestion(int number, List<ExpertSystemQuestion> List)
        {
            richTextBoxExpert.Text = List[number].QuestionText;
            radioButton1.Text = List[number].AnswerOne.Text;
            radioButton2.Text = List[number].AnswerTwo.Text;

            //groupBox1.Controls.Add(CreateRadioButton(number, List[number].AnswerOne.Text));
            //groupBox1.Controls.Add(CreateRadioButton(number + 2, List[number].AnswerTwo.Text));
        }

        private void Total(List<ExpertSystemQuestion> List)
        {
            //int total = 0;
            foreach (ExpertSystemQuestion question in List)
            {
                Program.Balls.Add(question.CheckedAnswerWigth());
                //total += question.CheckedAnswerWigth();
            }
            //return total;
        }

        private RadioButton CreateRadioButton(int number, string text)
        {
            var RadioButton = new RadioButton
            {
                AutoSize = true,
                Location = new System.Drawing.Point(6, 28 + number*20),
                Name = $"radioButton{number}",
                Size = new System.Drawing.Size(69, 21),
                TabIndex = 1,
                TabStop = true,
                Text = text,
                Checked = false
            };
            RadioButton.UseVisualStyleBackColor = true;
            RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged); 

            return RadioButton;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ExpertSystemForm_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

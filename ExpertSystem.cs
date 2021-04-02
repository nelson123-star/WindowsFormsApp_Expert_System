using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp_Expert_System
{
    public partial class ExpertSystemForm : Form
    {
        private ExpertSystemCore Core;
        private SqlConnection SqlConnection = null;
        private SqlDataAdapter adapter = null;
        ExpertSystemQuestion data = new ExpertSystemQuestion();
        ExpertSystemQuestion question = new ExpertSystemQuestion();
        List<ExpertSystemQuestion> QuestionList;
        public int Number = 0;

        public ExpertSystemForm()
        {
            InitializeComponent();
            Core = new ExpertSystemCore(this);
            QuestionList = new List<ExpertSystemQuestion>();
            Question();
            WriteQuestion(Number);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Open();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Save();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.SaveAs();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.AddProposition();
        }

        private void button1_Click(object sender, EventArgs e)
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
            //data.RichTextBoxQuestion(richTextBoxExpert);
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            //Checked - Возвращает или задает значение, указывающее, выбран ли данный элемент управления.
            Number++;
            
            if (Number < QuestionList.Count)
            {
                WriteQuestion(Number);
                if (radioButton1.Checked) QuestionList[Number].Answer = 1;
                else if (radioButton2.Checked) QuestionList[Number].Answer = 2;
                else if (radioButton3.Checked) QuestionList[Number].Answer = 3;
            }
            else Total();
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //question.RadioButtonQuestionOne(radioButton1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //question.RadioButtonQuestionTwo(radioButton2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //question.RadioButtonQuestionThree(radioButton3);
        }
        private void Question()
        {
            string sFileName = "food.txt";
            StreamReader textreader = new StreamReader(sFileName);
            while (!textreader.EndOfStream)
            {
                ExpertSystemQuestion question = new ExpertSystemQuestion();
                question.QuestionText = textreader.ReadLine();
                question.AnswerOne.Text = textreader.ReadLine();
                question.AnswerOne.Wigth = Convert.ToInt32((textreader.ReadLine()));
                question.AnswerTwo.Text = textreader.ReadLine();
                question.AnswerTwo.Wigth = Convert.ToInt32(textreader.ReadLine());
                question.AnswerThree.Text = textreader.ReadLine();
                question.AnswerThree.Wigth = Convert.ToInt32(textreader.ReadLine());
                QuestionList.Add(question);
            }
            textreader.Close();
        }
        private void WriteQuestion(int number)
        {
            richTextBoxExpert.Text = QuestionList[number].QuestionText;
            radioButton1.Text = QuestionList[number].AnswerOne.Text;
            radioButton2.Text = QuestionList[number].AnswerTwo.Text;
            radioButton3.Text = QuestionList[number].AnswerThree.Text;
        }
        
        private void Total()
        {
            int total = 0;
            foreach (ExpertSystemQuestion question in QuestionList)
            {
                total += question.CheckedAnswerWigth();
            }
            richTextBoxOutputExpert.Text = "Ваш результат " + total + ". Желаем успехов!!!";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}

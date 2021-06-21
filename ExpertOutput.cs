using System;
using NeuralNetwork;
using System.Windows.Forms;

namespace WindowsFormsApp_Expert_System
{
    public partial class ExpertOutput : Form
    {
        public ExpertOutput()
        {
            InitializeComponent();
            //foreach (var human in Program.HumanList)
            //{
                
            //}
            if (Program.Expertoutput < 0.5) richTextBox1.Text = "Вы показали плохие результаты в данном тестировании. " + "\n" +
                           $"Вердикт: мы не рекомендуем вас на должность "   //{human.profession}
                           + "\n" + "\n" + "До свидание!";
            else richTextBox1.Text = "Вы показали хорошие результаты в данном тестировании. " + "\n" +
                       $"Вердикт: мы рекомендуем вас на должность "   //{human.profession}
                       + "\n" + "\n" + "До новых встреч!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Program.Expertoutput < 0.5) richTextBox1.Text = "Вы показали плохие результаты в данном тестировании. " + "\n" +
           $"Вердикт: мы не рекомендуем вас на должность "   //{human.profession}
           + "\n" + "\n" + "До свидание!";
            else richTextBox1.Text = "Вы показали хорошие результаты в данном тестировании. " + "\n" +
                       $"Вердикт: мы рекомендуем вас на должность "   //{human.profession}
                       + "\n" + "\n" + "До новых встреч!";
        }
    }
}
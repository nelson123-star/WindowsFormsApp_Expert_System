using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsApp_Expert_System
{

    public partial class Regestr : Form
    {
        public int Number = 0;
        public bool Auth;

        public Regestr()
        {
            InitializeComponent();
        }
        private void Write()
        {
            Human human = new Human();
            human.name = textBoxName.Text;
            human.surname = textBoxSurname.Text;
            human.age = Convert.ToInt32(textBoxAge.Text);
            human.gender = comboBox1.Text;
            human.comment = richTextBoxComment.Text;
            human.profession = comboBox2.Text;
            Program.HumanList.Add(human);
        }
        private void TextBoxAge(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void buttonRegestr_Click(object sender, EventArgs e)
        {
            string Comment = "";
            int Age = 0;
            string Gender = "";
            string Name = textBoxName.Text;
            if(Name == "") MessageBox.Show("Пожалуйста, введите ваше имя");
            string Surname = textBoxSurname.Text;
            if (Surname == "") MessageBox.Show("Пожалуйста, введите вашу фамилию");
            if (textBoxAge.Text == "") MessageBox.Show("Пожалуйста, укажите ваш возраст");
            else if(textBoxAge.Text != "") Age = Convert.ToInt32(textBoxAge.Text);
            else if (Age < 18 && Age >= 60)
            {
                MessageBox.Show($"Если ваш возраст {Age}, вы не можете работать.");
                Application.Exit();
            }
            if(comboBox1.SelectedItem == null) MessageBox.Show("Пожалуйста, укажите ваш пол");
            else Gender = comboBox1.SelectedItem.ToString();
            if (richTextBoxComment.Text == null) Comment = "";
            else Comment = richTextBoxComment.Text;
            Write();

            
            Number++;

            Output(Number);
            MessageBox.Show("Регистрация прошла успешно!");
        }
        private void Output(int number)
        {
            Program.Auth = true;
            this.Close();
            //ShowDialog(new ExpertSystemForm());
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void richTextBoxComment_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

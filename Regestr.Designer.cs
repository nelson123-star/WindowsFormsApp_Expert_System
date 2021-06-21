
namespace WindowsFormsApp_Expert_System
{
    partial class Regestr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegestr = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelProfession = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonRegestr
            // 
            this.buttonRegestr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRegestr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegestr.Location = new System.Drawing.Point(300, 304);
            this.buttonRegestr.Name = "buttonRegestr";
            this.buttonRegestr.Size = new System.Drawing.Size(178, 75);
            this.buttonRegestr.TabIndex = 0;
            this.buttonRegestr.Text = "Зарегистрироваться";
            this.buttonRegestr.UseVisualStyleBackColor = false;
            this.buttonRegestr.Click += new System.EventHandler(this.buttonRegestr_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Введите имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 44);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(129, 17);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Введите фамилию";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(13, 72);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(119, 17);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Введите возраст";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(147, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(309, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(147, 41);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(309, 22);
            this.textBoxSurname.TabIndex = 5;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(147, 69);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(309, 22);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAge);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(12, 97);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(34, 17);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Пол";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(147, 123);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(309, 135);
            this.richTextBoxComment.TabIndex = 11;
            this.richTextBoxComment.Text = "";
            this.richTextBoxComment.TextChanged += new System.EventHandler(this.richTextBoxComment_TextChanged);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(12, 123);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(98, 17);
            this.labelComment.TabIndex = 12;
            this.labelComment.Text = "Комментарии";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "Ж"});
            this.comboBox1.Location = new System.Drawing.Point(147, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(12, 268);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(177, 17);
            this.labelProfession.TabIndex = 15;
            this.labelProfession.Text = "Выберите специальность";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Junior C#",
            "Работник общественного питания"});
            this.comboBox2.Location = new System.Drawing.Point(195, 264);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Regestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 391);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonRegestr);
            this.Name = "Regestr";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegestr;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
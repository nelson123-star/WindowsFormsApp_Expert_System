using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Expert_System
{
    public class ExpertSystemCore
    {
        public ExpertSystemCore(ExpertSystemForm app_form)
        {
            data = new ExpertSystemData();

            form = new ExpertSystemWindowsForm();

            (form as ExpertSystemWindowsForm).Form = app_form;

            FFileName = "";
        }

        public void AddProposition()
        {
            Proposition prop = new Proposition();

            prop.caption = "Тест";

            prop.itis = true;

            data.propositions.Add(prop);

            form.Draw_propositions(data.propositions);
        }

        /// <summary>
        /// Скрытое имя файла
        /// </summary>

        private string FFileName;

        /// <summary>
        /// Имя файла, открытого в даннмый момент
        /// </summary>

        public string FileName
        {
            get
            {
                return FFileName;
            }
        }

        /// <summary>
        /// База знаний экспертной системы,
        /// а так же другие нужные для работы данные
        /// </summary>

        private ExpertSystemData data;

        /// <summary>
        /// Связь с формой приложения через интерфейс IExpertSystemForm
        /// </summary>

        private IExpertSystem form;

        /// <summary>
        /// Обновить форму приложения
        /// </summary>

        private void UpdateForm()
        {
            form.Caption = FileName;
        }

        /// <summary>
        /// Открыть файл экспертной системы
        /// </summary>

        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Открыть проект...";

            openFileDialog.Filter = "Файлы экспертных систем|*.txt|Все файлы|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            try
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                data = (ExpertSystemData)formatter.Deserialize(fs);

                fs.Close();

                FFileName = openFileDialog.FileName;

                UpdateForm();

                form.Draw_propositions(data.propositions);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранить файл экспертной системы
        /// </summary>

        public void Save()
        {
            //Если имя файла не задано то вызываем диалог выбора файла

            if (FFileName == "")
            {
                SaveAs();

                return;
            }

            FileStream fs = new FileStream(FFileName, FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, data);

            fs.Close();

            UpdateForm();
        }

        /// <summary>
        /// Сохранить файл экспертной системы с диалогом выбора файла
        /// </summary>

        public void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Сохранение проекта...";

            saveFileDialog.Filter = "Файлы экспертных систем|*.txt|Все файлы|*.*";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            FFileName = saveFileDialog.FileName;

            Save();
        }

        public void Add()
        {

        }
    }
}

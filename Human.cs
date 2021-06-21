using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Expert_System
{
    class Human
    {
        /*В данном классе хранится модель кандидата: 
         -Имя, Фамилия, Возраст, Пол, Его комментарий, в котором может указать опыт работы, стек технологий, с которыми кандидат работал.
         Также модель содержит поля и свойства результатов тесторования кандидата на такие качества как: 
        Порядочность, Знания предметной области, Стремление к развитию, Коммуникативные навыки, Заинтересованность к работе, Ответственность */

        private string Name; //Имя
        private string Surname; //Фамилия
        private int Age; //Возраст
        private string Gender; //Пол
        private string Comment; //Комментарий
        private string Profession; //Профессия
        private int Poryadochnost; //Порядочность
        private int Knowledge; //Знания предметной области
        private int Improving; //Стремление к развитию
        private int Communication; //Коммуникативные навыки
        private int JobInteresting; //Заинтересованность к работе
        private int Responsible; //Ответственность

        public string name { get => Name; set => Name = value; }
        public string surname { get => Surname; set => Surname = value; }
        public int age { get => Age; set => Age = value; }
        public string gender { get => Gender; set => Gender = value; }
        public string comment { get => Comment; set => Comment = value; }
        public string profession { get => Profession; set => Profession = value; }

        public int poryadochnost { get => Poryadochnost; set => Poryadochnost = value; }
        public int knowledge { get => Knowledge; set => Knowledge = value; }
        public int improving { get => Improving; set => Improving = value; }
        public int communication { get => Communication; set => Communication = value; }
        public int jobInteresting { get => JobInteresting; set => JobInteresting = value; }
        public int responsible { get => Responsible; set => Responsible = value; }

    }
}

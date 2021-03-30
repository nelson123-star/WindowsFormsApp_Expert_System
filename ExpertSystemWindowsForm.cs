using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp_Expert_System
{
    class ExpertSystemWindowsForm : IExpertSystem
    {
        public ExpertSystemForm Form { get; set; }

        /// <summary>
        /// Заголовок формы
        /// </summary>

        public string Caption
        {
            get
            {
                if (Form != null) return Form.Text; else return "NULL";
            }
            set
            {
                if (Form != null) Form.Text = value;
            }
        }

        /// <summary>
        /// Перерисовать утверждения
        /// </summary>
        /// <param name="propositions">Список утверждений</param>

        public void Draw_propositions(List<Proposition> propositions)
        {   

        }



        /// <summary>
        /// Перерисовать строку
        /// </summary>
        /// <param name="j">Номер строки</param>
        /// <param name="item">Утверждение</param>

    }
}

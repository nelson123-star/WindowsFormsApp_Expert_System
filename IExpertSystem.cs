using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Expert_System
{

    interface IExpertSystem
    {
        /// <summary>
        /// Заголовок формы
        /// </summary>

        string Caption { get; set; }

        /// <summary>
        /// Перерисовать утверждения
        /// </summary>
        /// <param name="propositions">Список утверждений</param>

        void Draw_propositions(List<Proposition> propositions);

    }

}

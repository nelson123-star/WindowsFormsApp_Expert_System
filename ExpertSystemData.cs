using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Expert_System
{
    [Serializable]
    public class ExpertSystemData
    {
        public List<Proposition> propositions;
        public ExpertSystemData()
        {
            propositions = new List<Proposition>();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

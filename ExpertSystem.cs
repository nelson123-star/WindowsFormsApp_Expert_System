using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp_Expert_System
{
    public partial class ExpertSystemForm : Form
    {
        private ExpertSystemCore Core;
        private SqlConnection SqlConnection = null;
        private SqlDataAdapter adapter = null;
        public ExpertSystemForm()
        {
            InitializeComponent();
            Core = new ExpertSystemCore(this);
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
    }
}

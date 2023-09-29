using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolledOutDevTool
{
    public partial class FormAdd : Form
    {
        DataSet stgref;
        FormCourse er;
        DataRow[] dr;
        public FormAdd(DataSet stages, FormCourse refe)
        {
            InitializeComponent();
            stgref = stages;
            er = refe;
            
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = stgref.Tables[0];
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.AllowUserToAddRows = false;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow i in dataGridView2.SelectedRows)
            {
                dr = stgref.Tables[0].Select("UUID = '" + i.Cells[0].Value.ToString() + "'");
                foreach(DataRow w in dr)
                {
                    er.receive(w);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if(textBox1.Text.Length == 0)
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = null;
            }
            else
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}*'", textBox1.Text);
            }

            
        }
    }
}

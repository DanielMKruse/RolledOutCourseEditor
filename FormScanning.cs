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
    public partial class FormScanning : Form
    {
        public FormScanning()
        {
            InitializeComponent();
        }

        private void FormScan_Load(object sender, EventArgs e)
        {

        }

        public void initProgBar(int i)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = i;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
        }

        public void progStep()
        {
            progressBar1.PerformStep();
            label1.Text = "Scanning stages " + progressBar1.Value + " of " + progressBar1.Maximum;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JICalculatorPRO
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutCalculatorPROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights reserved with ProgramInUrdu.com - 2020", "About Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

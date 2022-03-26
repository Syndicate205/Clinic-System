using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIpractice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void immButton_Click(object sender, EventArgs e)
        {
            ImmunizationEntryForm newform = new ImmunizationEntryForm();
            this.Hide();
            newform.ShowDialog();
        }
        private void consultButton_Click(object sender, EventArgs e)
        {
            ConsultationEntryForm newform = new ConsultationEntryForm();
            this.Hide();
            newform.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Update newform = new Update();
            this.Hide();
            newform.ShowDialog();
        }
    }
}

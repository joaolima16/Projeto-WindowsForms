using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios_Empresa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Challenge_3 clForm = new Challenge_3();
            clForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CEP formCep = new CEP();
            formCep.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormBank form = new FormBank();
            form.Show();
            this.Visible = false;
        }
    }
}

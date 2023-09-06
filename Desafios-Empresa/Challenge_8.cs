using AltoHttp;
using Desafios_Empresa.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios_Empresa
{
    public partial class Challenge_8 : Form
    {
        Challenge_8Controller challenge = new Challenge_8Controller();
        public Challenge_8()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = challenge.DownloadImage("https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png");
            txbImage.Text = challenge.ConvertTo64(path);
         }
        private void Button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Visible = false;
        }
    }
}


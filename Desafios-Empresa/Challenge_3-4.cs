using Desafios_Empresa.Controllers;
using Desafios_Empresa.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios_Empresa
{
    public partial class Challenge_3 : Form

    {
        Challenge_3_4Controller challenge_3_ = new();
        private List<clsTeste> clList = new List<clsTeste>();
        public Challenge_3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clList = challenge_3_.GenerateValues();
            challenge_3_.GenerateJSON(clList);
            ShowInformationsGridView();
        }

        private void ShowInformationsGridView()
        {
            if (dataGridJson != null)
            {
                dataGridJson.DataSource = clList;
                dataGridJson.Width = 280;
            }
          
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Visible = false;
        }
    }
}

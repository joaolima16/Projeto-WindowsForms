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
        private List<clsTeste> clList = new List<clsTeste>();
        public Challenge_3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                clList.Add(new clsTeste(i, DateTime.Now));
            }
            GenerateJSON();

        }
        private void GenerateJSON()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            string pathExists = Path.Combine(Application.StartupPath, "Archives");

            try
            {
                if (!Directory.Exists(pathExists))
                {
                    Directory.CreateDirectory(pathExists);
                }
                string path = Path.Combine(pathExists, "data.json");
                File.WriteAllText(path, clJSON.SerializeJSON(clList), Encoding.UTF8);
                MessageBox.Show("Arquivo salvo");
                showInformationsGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo:" + ex.Message);
            }
        }
        private void showInformationsGridView()
        {
            if (dataGridJson != null)
            {
                dataGridJson.DataSource = clList;
                dataGridJson.Width = 280;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Visible = false;
        }
    }
}

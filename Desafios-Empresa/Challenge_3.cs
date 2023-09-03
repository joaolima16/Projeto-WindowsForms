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
        List<clsTeste> clList = new List<clsTeste>();
        public Challenge_3()
        {
            InitializeComponent();
        }

        private void Challenge_3_Load(object sender, EventArgs e)
        {

        }

        private void btnJson(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                clList.Add(new clsTeste(i, DateTime.Now));
            }
            GenerateJSON();

        }
        private async void GenerateJSON()
        {
            try
            {
                SaveFileDialog svDialog = new SaveFileDialog();
                svDialog.FileName = "data.json";
                svDialog.Filter = "(*.json)|*.json";
                if (svDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(svDialog.FileName))
                    {
                        foreach (object obj in clList)
                        {

                            string json = JsonConvert.SerializeObject(obj);
                            sw.WriteLine(json);

                        }
                    }
                    MessageBox.Show("Arquivo salvo");
                    showInformationsGridView();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showInformationsGridView()
        {
            dataGridJson.DataSource = clList;
            dataGridJson.Width = 280;

        }
    }
}

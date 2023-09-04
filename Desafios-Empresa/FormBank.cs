using Desafios_Empresa.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios_Empresa
{
    public partial class FormBank : Form
    {
        public FormBank()
        {
            InitializeComponent();
        }

        private async void FormBank_Load(object sender, EventArgs e)
        {
            string urlApi = "https://brasilapi.com.br/api/banks/v1";
            var client = new RestClient();

            var request = new RestRequest(urlApi, Method.Get);
            RestResponse restResponse = await client.ExecuteAsync(request);
            if (restResponse.IsSuccessStatusCode)
            {
                dgvData.DataSource = JsonConvert.DeserializeObject<List<Banco>>(restResponse.Content);
                dgvData.Width = 600;
                dgvData.AutoResizeColumns();
                dgvData.AutoResizeRow();

            }
        }
    }
}

using Desafios_Empresa.Controllers;
using Desafios_Empresa.Models;
using Newtonsoft.Json;
using RestSharp;


namespace Desafios_Empresa
{
    public partial class FormBank : Form
    {
        Challenge_7Controller challenge = new();
        public FormBank()
        {
            InitializeComponent();
        }

        private async void FormBank_Load(object sender, EventArgs e)
        {
            RestResponse restResponse = await challenge.FindValues();
            if (restResponse.IsSuccessStatusCode)
            {
                dgvData.DataSource = challenge.DesserializeJSON(restResponse);
                dgvData.Width = 600;
                dgvData.AutoResizeColumns();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Visible = false;
        }
    }
}

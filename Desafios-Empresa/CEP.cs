
using Desafios_Empresa.Controllers;

namespace Desafios_Empresa
{
    public partial class CEP : Form
    {
        Challenge_6Controller challenge_6 = new();
        public CEP()
        {
            InitializeComponent();
        }
        private async void ShowDataValues()
        { 
                try
                {
                    var result = await challenge_6.ShowDataAsync(txbCep.Text);
                    txbBairro.Text = result.@return.bairro;
                    txbCidade.Text = result.@return.cidade;
                    txbUf.Text = result.@return.uf;
                    txbRua.Text = result.@return.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

  
            }
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            ShowDataValues();
        }

        private void TxbCep_TextChanged(object sender, EventArgs e)
        {
            if (txbCep.TextLength >= 8)
            {
                btnVerify.Enabled = true;
                btnClear.Enabled = true;
            }
            else
            {
                btnVerify.Enabled = false;
            }
        }
        private void TxbClear_Click(object sender, EventArgs e)
        {
            txbCep.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            txbUf.Text = "";
            txbRua.Text = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Visible = false;
        }
    }
}

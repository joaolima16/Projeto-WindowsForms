
namespace Desafios_Empresa
{
    public partial class CEP : Form
    {
        public CEP()
        {
            InitializeComponent();
        }
        private async void showDataAsync()
        {
            using (var wbService = new ServiceReference1.AtendeClienteClient())
            {
                try
                {
                    var result = await wbService.consultaCEPAsync(txbCep.Text);
                    txbBairro.Text = result.@return.bairro;
                    txbCidade.Text = result.@return.cidade;
                    txbUf.Text = result.@return.uf;
                    txbRua.Text = result.@return.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            showDataAsync();
        }

        private void txbCep_TextChanged(object sender, EventArgs e)
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


        private void txbClear_Click(object sender, EventArgs e)
        {
            txbCep.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            txbUf.Text = "";
            txbRua.Text = "";
        }
    }
}

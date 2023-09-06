using Desafios_Empresa.Controllers;

namespace Desafios_Empresa
{
    public partial class Form1 : Form
    {
        Challenge_1_2Controller challenge = new();
        private List<int> lsValues = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbValues.Text, out int lsValue))
            {
                lsValues.Add(lsValue);
                txbValues.Clear();
                ShowValues();
            }
            else
            {
                MessageBox.Show("Digite um número inteiro válido.");
            }
        }
        private void ShowValues()
        {
            foreach (object o in lsValues)
            {
                List<int> sortedValues = new List<int>(lsValues);
                sortedValues.Sort();
                String result = string.Join(", ", sortedValues);
                txbResult.Text = result;
            }
        }
        private void BtnGenerate_click(object sender, EventArgs e)
        {
            challenge.SaveArchive(lsValues);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Visible = false;
        }
    }
}
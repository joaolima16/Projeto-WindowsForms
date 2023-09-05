namespace Desafios_Empresa
{
    public partial class Form1 : Form
    {
        private List<int> lsValues = new List<int>();
        private List<int> sortedValues = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
                lbValues.Text = result;
            }
        }
        private void SaveArchive()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            string pathExists = Path.Combine(Application.StartupPath, "Archives");
            if (!Directory.Exists(pathExists))
            {
                Directory.CreateDirectory(pathExists);
            }
            string path = Path.Combine(pathExists, "OrdenarNumeros.txt");


            foreach (object obj in lsValues)
            {
                List<int> sortedValues = new List<int>(lsValues);
                sortedValues.Sort();
                File.WriteAllLines(path, sortedValues.ConvertAll(x => x.ToString()));
            }

            MessageBox.Show("Arquivo salvo com sucesso!");

        }


        private void BtnGenerate_click(object sender, EventArgs e)
        {
            SaveArchive();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Visible = false;
        }
    }
}
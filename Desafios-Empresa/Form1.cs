namespace Desafios_Empresa
{
    public partial class Form1 : Form
    {
        public List<int> lsValues = new List<int>();
        public List<int> sortedValues = new List<int>();
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
                showValues();
            }
            else
            {
                MessageBox.Show("Digite um n�mero inteiro v�lido.");
            }
        }
        private void showValues()
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
            saveFile.FileName = "Numeros_ordenar.txt";
            saveFile.Filter = "(*.txt)|*.txt";
         
            MessageBox.Show(Environment.CurrentDirectory);
            if(saveFile.ShowDialog() == DialogResult.OK) {
                String filePath = saveFile.FileName;
            using(StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (object obj in lsValues)
                    {
                        List<int> sortedValues = new List<int>(lsValues);
                        sortedValues.Sort();
                        String value = string.Join("\n", obj);
                        sw.WriteLine(value);
                       
                    }
                    MessageBox.Show("Arquivo salvo com sucesso!");
                }
            }
        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            SaveArchive();
        }
    }
}
namespace Desafios_Empresa.Controllers
{
    public class Challenge_1_2Controller
    {
        public void SaveArchive(List<int> lsValues)
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
    }
}

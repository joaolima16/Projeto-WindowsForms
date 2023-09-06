using Desafios_Empresa.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Empresa.Controllers
{
    public  class Challenge_3_4Controller
    {
       public List<clsTeste> GenerateValues()
        {
            List<clsTeste> lsTeste = new List<clsTeste>();
            for (int i = 1; i <= 100; i++)
            {
                lsTeste.Add(new clsTeste(i, DateTime.Now));
            }
            return lsTeste;
        }
       public void GenerateJSON(List<clsTeste> clList)
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
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo:" + ex.Message);
            }
        }
    }
}

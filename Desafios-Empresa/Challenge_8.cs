using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios_Empresa
{
    public partial class Challenge_8 : Form
    {
        private HttpDownloader httpDownloader = null;
        public Challenge_8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadImage("https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png");
        }
        private void DownloadImage(string url)
        {
            string pathExists = Path.Combine(Application.StartupPath, "Archives");

            try
            {

                if (!Directory.Exists(pathExists))
                {
                    Directory.CreateDirectory(pathExists);
                }

                string path = Path.Combine(pathExists);
                string pathImage = $"{path}\\{Path.GetFileName(url)}";
                httpDownloader = new HttpDownloader(url, pathImage);
                httpDownloader.Start();
                MessageBox.Show("Imagem baixada");
                ConvertTo64(pathImage);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertTo64(string path)
        {
            Image imagem = Image.FromFile(path);
            string base64 = ImageTo64(imagem);
            txbImage.Text = base64;
        }

        private string ImageTo64(Image image)
        {

            using (MemoryStream memory = new MemoryStream())
            {

                image.Save(memory, image.RawFormat);
                byte[] imageBytes = memory.ToArray();
                return Convert.ToBase64String(imageBytes);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Visible = false;
        }
    }
}


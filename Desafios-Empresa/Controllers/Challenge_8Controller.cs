using AltoHttp;

namespace Desafios_Empresa.Controllers
{
    public class Challenge_8Controller
    {
        private HttpDownloader httpDownloader = null;
        public string DownloadImage(string url)
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
                return pathImage;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
        public string ConvertTo64(string path)
        {
            Image imagem = Image.FromFile(path);
            string base64 = ImageTo64(imagem);
            return base64;
        }
    }
}

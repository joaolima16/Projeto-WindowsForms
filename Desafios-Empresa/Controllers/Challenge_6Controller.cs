using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Empresa.Controllers
{
    public class Challenge_6Controller
    {
        public async Task<ServiceReference1.consultaCEPResponse> ShowDataAsync(string cep)
        {
            using (var wbService = new ServiceReference1.AtendeClienteClient())
            {
                try
                {
                    var result = await wbService.consultaCEPAsync(cep);
                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

        }
    }
}

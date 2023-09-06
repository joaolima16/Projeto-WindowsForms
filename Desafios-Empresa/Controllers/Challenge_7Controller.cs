using Desafios_Empresa.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Empresa.Controllers
{
    public class Challenge_7Controller
    {

        public  async Task<RestResponse> FindValues()
        {
            try
            {
                string urlApi = "https://brasilapi.com.br/api/banks/v1";
                var client = new RestClient();

                var request = new RestRequest(urlApi, Method.Get);
                RestResponse restResponse = await client.ExecuteAsync(request);
                if (restResponse.IsSuccessStatusCode)
                {
                    return restResponse;
                }
                return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu o erro:" + ex.Message);
                return null;
            }
            
        }
        public List<Banco> DesserializeJSON(RestResponse restResponse)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Banco>>(restResponse.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return null;
            }
        }
    }
}

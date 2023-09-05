using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desafios_Empresa.Models
{
    public class clJSON
    {
        public static string SerializeJSON(List<clsTeste> clsteste)
        {
            return JsonSerializer.Serialize(clsteste);
        }
    }
}

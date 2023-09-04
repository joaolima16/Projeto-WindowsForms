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
        public string serializeJSON(clsTeste clsteste)
        {
            return JsonSerializer.Serialize(clsteste);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Empresa.Models
{
    public class clsTeste
    {
        public int code { get; set; }
        public DateTime description { get; set; }
        public clsTeste(int code, DateTime date)
        {
            this.code = code;
            this.description = date;
            showInformations();
        }
        public void showInformations()
        {
            Console.WriteLine("Code: " + this.code);
            Console.WriteLine("Date:" + this.description);
        }
    }
}

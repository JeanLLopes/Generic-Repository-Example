using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGenerico.CRUD.Model.Models
{
    public class AmigosModel : Base.BaseModel
    {
        public String Nome { get; set; }
        public String Rg { get; set; }
        public String Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
    }
}

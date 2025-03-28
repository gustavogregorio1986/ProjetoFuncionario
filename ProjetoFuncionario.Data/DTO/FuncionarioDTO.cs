using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Data.DTO
{
    public class FuncionarioDTO
    {
        public Guid Id { get; set; }

        public string? NomeFuncionario { get; set; }

        public string? EmailCorporativo { get; set; }

        public string? Cpf { get; set; }

        public string? Emnpresa { get; set; }

        public string? Setor { get; set; }

        public int Ativo { get; set; }
    }
}

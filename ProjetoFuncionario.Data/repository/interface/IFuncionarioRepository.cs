using ProjetoFuncionario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Data.repository
{
    public interface IFuncionarioRepository
    {
        void Adicionar(Funcionario funcionario);

        List<Funcionario> ListarFuncionarios();
    }
}

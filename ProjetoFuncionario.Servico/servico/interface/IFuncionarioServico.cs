using ProjetoFuncionario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Servico.servico
{
    public interface IFuncionarioServico
    {
        void Adicionar(Funcionario funcionario);

        List<Funcionario> ListarFuncionarios();
    }
}

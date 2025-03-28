using ProjetoFuncionario.Data.repository;
using ProjetoFuncionario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Servico.servico
{
    internal class FuncionarioServico : IFuncionarioServico
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioServico(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;   
        }

        public void Adicionar(Funcionario funcionario)
        {
            _funcionarioRepository.Adicionar(funcionario);
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _funcionarioRepository.ListarFuncionarios();
        }
    }
}

using ProjetoFuncionario.Data.Context;
using ProjetoFuncionario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Data.repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DbContexto _db;

        public FuncionarioRepository(DbContexto db)
        {
            _db = db;
        }

        public void Adicionar(Funcionario funcionario)
        {
            _db.Add(funcionario);
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _db.Funcionarios.ToList();
        }
    }
}

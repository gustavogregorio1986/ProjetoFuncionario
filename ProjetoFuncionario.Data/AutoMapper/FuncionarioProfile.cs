using AutoMapper;
using ProjetoFuncionario.Data.DTO;
using ProjetoFuncionario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Data.AutoMapper
{
    public class FuncionarioProfile : Profile
    {
        public FuncionarioProfile()
        {
            CreateMap<Funcionario, FuncionarioDTO>();
        }
    }
}

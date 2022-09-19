using SiteGabriel.Business.Core.Data;
using SiteGabriel.Business.Models.CadastroUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteGabriel.Business.Models.CadastrarUsuarios
{
    public interface ICadastroUsuarioRepository : IRepository<CadastrarUsuario>
    {
        Task<CadastrarUsuario> ObterUsuarioNome (Guid id);
    }
}

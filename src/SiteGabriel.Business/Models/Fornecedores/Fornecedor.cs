using SiteGabriel.Business.Core.Models;
using SiteGabriel.Business.Models.Produtos;
using System.Collections.Generic;

namespace SiteGabriel.Business.Models.Fornecedores
{
    public partial class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor tipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        //EF Relacoes
        public ICollection<Produto> Produtos { get; set; }
    }
}

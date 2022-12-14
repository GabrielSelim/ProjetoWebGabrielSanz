using SiteGabriel.Business.Core.Models;
using SiteGabriel.Business.Models.Fornecedores;
using System;

namespace SiteGabriel.Business.Models.Produtos
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        //EF Relacoes
        public Fornecedor Fornecedor { get; set; }
    }
}

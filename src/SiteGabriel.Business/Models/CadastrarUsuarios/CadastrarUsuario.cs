using Castle.MicroKernel.SubSystems.Conversion;
using SiteGabriel.Business.Core.Models;
using System;

namespace SiteGabriel.Business.Models.CadastroUsuario
{
    public class CadastrarUsuario : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Sexo { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public decimal GorduraCorporal { get; set; }
        public decimal Imc { get; set; }
    }
}

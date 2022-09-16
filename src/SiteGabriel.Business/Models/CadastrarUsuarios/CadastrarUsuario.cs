using SiteGabriel.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteGabriel.Business.Models.CadastroUsuario
{
    class CadastroUsuario : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public enum _Sexo {M,F}
        public _Sexo Sexo { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public decimal GorduraCorporal { get; set; }
        public decimal Imc { get; set; }
    }
}

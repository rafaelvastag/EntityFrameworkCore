using System;
using System.Collections.Generic;

namespace ModBasic.Models
{
    public partial class Endereco
    {
        public Endereco()
        {
            Pessoa = new HashSet<Pessoa>();
        }

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public int? Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public ICollection<Pessoa> Pessoa { get; set; }
    }
}

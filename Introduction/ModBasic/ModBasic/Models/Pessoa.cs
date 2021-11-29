using System;
using System.Collections.Generic;

namespace ModBasic.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            PessoaTelefone = new HashSet<PessoaTelefone>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public long? Cpf { get; set; }
        public int? Endereco { get; set; }

        public Endereco EnderecoNavigation { get; set; }
        public ICollection<PessoaTelefone> PessoaTelefone { get; set; }
    }
}

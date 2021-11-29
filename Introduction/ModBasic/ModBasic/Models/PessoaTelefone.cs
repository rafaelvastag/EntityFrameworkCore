using System;
using System.Collections.Generic;

namespace ModBasic.Models
{
    public partial class PessoaTelefone
    {
        public int IdPessoa { get; set; }
        public int IdTelefone { get; set; }

        public Pessoa IdPessoaNavigation { get; set; }
        public Telefone IdTelefoneNavigation { get; set; }
    }
}

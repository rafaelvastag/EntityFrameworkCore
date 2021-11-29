using System;
using System.Collections.Generic;

namespace ModBasic.Models
{
    public partial class Telefone
    {
        public Telefone()
        {
            PessoaTelefone = new HashSet<PessoaTelefone>();
        }

        public int Id { get; set; }
        public int? Numero { get; set; }
        public int? Ddd { get; set; }
        public int? Tipo { get; set; }

        public TelefoneTipo TipoNavigation { get; set; }
        public ICollection<PessoaTelefone> PessoaTelefone { get; set; }
    }
}

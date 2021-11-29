using System;
using System.Collections.Generic;

namespace ModBasic.Models
{
    public partial class TelefoneTipo
    {
        public TelefoneTipo()
        {
            Telefone = new HashSet<Telefone>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public ICollection<Telefone> Telefone { get; set; }
    }
}

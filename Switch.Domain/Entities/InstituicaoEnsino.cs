using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Switch.Domain.Entities
{
    public class InstituicaoEnsino
    {
        public int Id { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime? AnoFormacao { get; set; }
    }
}

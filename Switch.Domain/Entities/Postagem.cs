using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }
        public string UrlContetudo { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class JuegoEntity
    {
        [Key]
        public string Titulo { get; set; }

        public string Caratula { get; set; }
        public string Categoria { get; set; }
    }
}

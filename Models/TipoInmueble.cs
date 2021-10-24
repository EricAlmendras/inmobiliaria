using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class TipoInmueble
    {
        public int TipoInmuebleId { get;set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
        public virtual ICollection<Vivienda> Viviendas { get; set; }
    }
}

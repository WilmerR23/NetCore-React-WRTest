using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Models
{
    public class Contribuyente : Base
    {
        public int EstadoId { get; set; }
        public string Nombre { get; set; }
        public int TipoId { get; set; }
        public IEnumerable<Comprobante> Comprobantes { get; set; }
        public EstadoContribuyente Estado { get; set; }
        public TipoContribuyente Tipo { get; set; }
    }
}

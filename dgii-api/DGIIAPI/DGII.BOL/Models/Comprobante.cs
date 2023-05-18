using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Models
{
    public class Comprobante : Base
    {
        public decimal Itbis18 { get; set; }
        public decimal Monto { get; set; }
        public string Ncf { get; set; }
        public int ContribuyenteId { get; set; }
        public Contribuyente Contribuyente { get; set; }
    }
}

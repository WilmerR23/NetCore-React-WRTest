using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Dtos
{
    public class ComprobanteDto : BaseDto
    {
        public decimal Itbis18 { get; set; }
        public decimal Monto { get; set; }
        public string Ncf { get; set; }
    }
}

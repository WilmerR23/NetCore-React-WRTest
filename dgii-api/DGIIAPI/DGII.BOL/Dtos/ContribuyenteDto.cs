using DGII.BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Dtos
{
    public class ContribuyenteDto : BaseDto
    {
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int TotalItebis { get; set; }
    }
}

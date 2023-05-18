using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        /* Propiedad incluida como prevencion para en caso de que se necesiten
           hacer reportes de data por fecha de registro del contribuyente */
        public DateTime fechaRegistro { get; set; }  
        public string rncCedula { get; set; }
    }
}

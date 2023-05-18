using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Models
{
    public abstract class SmallEntities
    {   // Clase para esas entidades que tienen comunes y pocas propiedades 
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

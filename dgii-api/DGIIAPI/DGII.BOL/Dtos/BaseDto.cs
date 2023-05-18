using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BOL.Dtos
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public string rncCedula { get; set; }
    }
}

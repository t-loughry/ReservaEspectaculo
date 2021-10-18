using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaEspectaculo.ViewModels
{
    public class MesVM
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaEspectaculo.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }

        [Display(Name = "Fecha de alta")]
        [DataType(DataType.Date)]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = "El titular de la reserva es requerido")]
        [Display(Name = "Titular de la reserva")]
        public int ClienteId { get; set; }

        [Display(Name = "Titular de la reserva")]
        public Cliente Cliente { get; set; }

        [Display(Name = "Cantidad de Butacas")]
        public int CantidadButacas { get; set; }

        public int FuncionId { get; set; }

        public Funcion Funcion { get; set; }

        public Boolean ReservaActiva { get; set; }

        [NotMapped]
        public double Recaudacion { get; set; }



    }
}


using Microsoft.AspNetCore.Mvc;
using ReservaEspectaculo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaEspectaculo.ViewModels
{
    public class SelecionarFechaVM
    {
        [Required]
        [Display(Name = "Pelicula")]
        public int PeliculaId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Remote(action: "ValidarFecha", controller: "Peliculas")]
        public DateTime Desde { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Remote(action: "ValidarFecha", controller: "Peliculas")]
        public DateTime Hasta { get; set; }

    }
}

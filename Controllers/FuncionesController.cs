using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReservaEspectaculo.Data;
using ReservaEspectaculo.Models;
using ReservaEspectaculo.ViewModels;

namespace ReservaEspectaculo.Controllers
{
    //[Authorize(Roles = "Empleado, Cliente")]
    public class FuncionesController : Controller
    {
        private readonly MiContexto _context;

        public FuncionesController(MiContexto context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index(int? id)
        {
            Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<Funcion, TipoSala> miContexto = default;

            if (id == null)
            {
                if (User.IsInRole("Empleado"))
                {
                    miContexto = _context.Funciones
                                          .Include(f => f.Pelicula)
                                          .Include(f => f.Sala)
                                          .Include(f => f.Pelicula.Genero)
                                          .Include(f => f.Reservas)
                                          .Include(f => f.Sala.TipoSala);
                }
                else
                {
                    miContexto = _context.Funciones.Where(f => f.Fecha >= DateTime.Today && f.Fecha <= DateTime.Today.AddDays(7))
                                                              .Include(f => f.Pelicula)
                                                              .Include(f => f.Sala)
                                                              .Include(f => f.Pelicula.Genero)
                                                              .Include(f => f.Reservas)
                                                              .Include(f => f.Sala.TipoSala);
                }
            }
            else
            {
                if (User.IsInRole("Empleado"))
                {
                    miContexto = _context.Funciones.Where(f => f.PeliculaId == id)
                                                              .Include(f => f.Pelicula)
                                                              .Include(f => f.Sala)
                                                              .Include(f => f.Pelicula.Genero)
                                                              .Include(f => f.Reservas)
                                                              .Include(f => f.Sala.TipoSala);
                }
                else
                {
                    miContexto = _context.Funciones.Where(f => f.PeliculaId == id && f.Fecha >= DateTime.Today && f.Fecha <= DateTime.Today.AddDays(7))
                                                              .Include(f => f.Pelicula)
                                                              .Include(f => f.Sala)
                                                              .Include(f => f.Pelicula.Genero)
                                                              .Include(f => f.Reservas)
                                                              .Include(f => f.Sala.TipoSala);
                }
            }

            //Intente hacer un Concat para no tener tantos if anidados pero no me salio 
            //La idea era tener la reestriccion de fecha, y si el rol es empleado 
            //concatenarle las funciones en el pasado.

            //if (User.IsInRole("Empleado"))
            //{
            //    miContexto.Concat(_context.Funciones.Where(f => f.Fecha < DateTime.Today)
            //                               .Include(f => f.Pelicula)
            //                              .Include(f => f.Sala)
            //                              .Include(f => f.Pelicula.Genero)
            //                              .Include(f => f.Reservas)
            //                              .Include(f => f.Sala.TipoSala));
            //}

            return View(await miContexto.ToListAsync());
        }               

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funciones
                .Include(f => f.Pelicula)
                .Include(f => f.Sala)
                .FirstOrDefaultAsync(m => m.FuncionId == id);
            if (funcion == null)
            {
                return NotFound();
            }

            return View(funcion);
        }

        [Authorize(Roles = "Empleado")]
        public IActionResult Create(string mensaje)
        {
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo");
            ViewData["SalaId"] = new SelectList(_context.Salas, "SalaId", "Numero");
            return View();
        }

        [Authorize(Roles = "Empleado")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionId,Fecha,Hora,Descripcion,ButacasDisponibles,Confirmada,PeliculaId,SalaId")] Funcion funcion)
        {

            if (funcion.Hora < DateTime.Now)
            {
                ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo", funcion.PeliculaId);
                ViewData["SalaId"] = new SelectList(_context.Salas, "SalaId", "Numero", funcion.SalaId);
                ModelState.AddModelError("", "La hora es incorrecta. No puede ser menor que la actual si la fecha de la funcion es para hoy.");
                return View(funcion);
            }                       

            var funciones = _context.Funciones.Include(f => f.Sala)
                                               .Include(f => f.Sala.TipoSala).ToList();
            
            if(!salaDisponible(funciones, funcion))
            {
                ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo", funcion.PeliculaId);
                ViewData["SalaId"] = new SelectList(_context.Salas, "SalaId", "Numero", funcion.SalaId);

                //ModelState.AddModelError("", $"Ya existe una función asignada a la sala {funcion.Sala.Numero} en ese dia y horario.");
                ModelState.AddModelError("", "Ya existe una funcion asignada a esa sala en esa franja horaria");
                return View(funcion);
                
            }

            if (ModelState.IsValid)
            {
                _context.Add(funcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo", funcion.PeliculaId);
            ViewData["SalaId"] = new SelectList(_context.Salas, "SalaId", "Numero", funcion.SalaId);
            return View(funcion);

        }

        private Boolean salaDisponible(List<Funcion> funciones, Funcion funcion)
        {
            var sala = _context.Salas.Find(funcion.SalaId);


            int salaN = sala.Numero;
            DateTime fecha = funcion.Fecha;
            DateTime hora = funcion.Hora;
            
            foreach (var item in funciones)
            {
                if(item.Fecha == fecha && item.Sala.Numero == salaN && calcularHora(hora, item.Hora))
                {
                    return false;
                }
            }
            return true;
        }

        private Boolean calcularHora(DateTime horaAqluilar, DateTime horaFuncion)
        {           
            DateTime alquilerCon2 = horaAqluilar.AddHours(2);
            DateTime horaFuncionCon2 = horaFuncion.AddHours(2);

            if(horaAqluilar == horaFuncion)
            {
                return true;
            }

            if(horaAqluilar >= horaFuncion && horaAqluilar <= horaFuncionCon2)
            {
                return true;
            }

            if(alquilerCon2 >= horaFuncion && alquilerCon2 <= horaFuncionCon2)
            {
                return true;
            }
            return false;
        }

        [Authorize(Roles = "Empleado")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funciones.FindAsync(id);
            if (funcion == null)
            {
                return NotFound();
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo", funcion.PeliculaId);
            ViewData["SalaId"] = new SelectList(_context.Salas, "SalaId", "Numero", funcion.SalaId);
            return View(funcion);
        }

        [Authorize(Roles = "Empleado")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuncionId,Fecha,Hora,Descripcion,ButacasDisponibles,Confirmada,PeliculaId,SalaId")] Funcion funcion)
        {
            if (id != funcion.FuncionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(funcion);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
                        
            return View(funcion);
        }

        [Authorize(Roles = "Empleado")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funciones
                .Include(f => f.Pelicula)
                .Include(f => f.Sala)
                .Include(f => f.Reservas)
                .FirstOrDefaultAsync(m => m.FuncionId == id);

            if(funcion.Reservas.Count > 0)
            {
                return RedirectToAction("noCancelar", "mensajes");
            }

            if (funcion == null)
            {
                return NotFound();
            }

            return View(funcion);
        }

        [Authorize(Roles = "Empleado")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcion = await _context.Funciones.FindAsync(id);
            _context.Funciones.Remove(funcion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionExists(int id)
        {
            return _context.Funciones.Any(e => e.FuncionId == id);
        }

        public async Task<IActionResult> ValidarFecha(DateTime fecha)
        {
                       
            if (fecha < DateTime.Today)
            {

                return Json($"La fecha es incorrecta. No puede estar en el pasado");
            }
            else
            {

                return Json(true);
            }
        }

        public  IActionResult VerReservas(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            
            var reservas =   _context.Reservas.Where(r => r.FuncionId == id)
                                                    .Include(r => r.Cliente)
                                                    .Include(r => r.Funcion)
                                                    .Include(r => r.Funcion.Pelicula).ToList();
            if (reservas == null)
            {
                return NotFound();
            }

            return View(reservas);
        }


    }
}

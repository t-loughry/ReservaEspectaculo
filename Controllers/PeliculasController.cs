﻿using System;
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
    [Authorize(Roles = "Empleado")]
    public class PeliculasController : Controller
    {
        private readonly MiContexto _context;

        public PeliculasController(MiContexto context)
        {
            _context = context;
        }
               
        public async Task<IActionResult> Index()
        {
            var miContexto = _context.Peliculas.Include(p => p.Genero);
            return View(await miContexto.ToListAsync());
        }
                
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas
                .Include(p => p.Genero)
                .FirstOrDefaultAsync(m => m.PeliculaId == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }
                
        public IActionResult Create()
        {
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nombre");
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PeliculaId,FechaLanzamiento,Titulo,Descripcion,Foto,GeneroId")] Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pelicula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nombre", pelicula.GeneroId);
            return View(pelicula);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nombre", pelicula.GeneroId);
            return View(pelicula);
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PeliculaId,FechaLanzamiento,Titulo,Descripcion,Foto,GeneroId")] Pelicula pelicula)
        {
            if (id != pelicula.PeliculaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pelicula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaExists(pelicula.PeliculaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nombre", pelicula.GeneroId);
            return View(pelicula);
        }
               
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas
                .Include(p => p.Genero)
                .FirstOrDefaultAsync(m => m.PeliculaId == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            _context.Peliculas.Remove(pelicula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaExists(int id)
        {
            return _context.Peliculas.Any(e => e.PeliculaId == id);
        }

        public async Task<IActionResult> BuscarBalance(int? id, string mensaje)
        {
            if(id == null)
            {
                ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo");
            }
            
            var pelicula = await _context.Peliculas.FindAsync(id);
            

            if(pelicula != null)
            {
              ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "PeliculaId", "Titulo", pelicula.PeliculaId);
            }

            if (mensaje != null)
            {
                ModelState.AddModelError("", mensaje);
            }


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> verBalance(SelecionarFechaVM model)
        {

            if(model.Hasta < model.Desde)
            {
                var peli = _context.Peliculas.Find(model.PeliculaId);
                return RedirectToAction("BuscarBalance","Peliculas", new { id = model.PeliculaId, mensaje=$"la fecha hasta: {model.Hasta.ToString("dd MMM")} no puede ser menor que la fecha desde {model.Desde.ToString("dd MMM")}" });
            }

            var reservas = _context.Reservas.Where(r => r.Funcion.PeliculaId == model.PeliculaId)
                                            .Where(r => r.Funcion.Fecha >= model.Desde)
                                            .Where(r => r.Funcion.Fecha <= model.Hasta)
                                            .Include(r => r.Funcion.Sala.TipoSala).ToList();

            var pelicula = _context.Peliculas.FirstOrDefault(p => p.PeliculaId == model.PeliculaId);
            return View(new verBalanceVM() {
                                            Pelicula = pelicula.Titulo, 
                                            Desde = model.Desde,
                                            Hasta = model.Hasta,
                                            Recaudacion = calcularRecaudacion(reservas)});
        }

        public async Task<IActionResult> ValidarFecha(DateTime hasta, DateTime desde)
        {         
            
            DateTime hoy = DateTime.Today;           
            if (hasta > hoy || desde > hoy)
            {

                return Json($"La fecha es incorrecta.No puede estar en el futuro");
            }
            else
            {

                return Json(true);
            }
        }
      

        private double calcularRecaudacion(List<Reserva> list)
        {
            double retorno = 0;
            foreach (var item in list)
            {
                retorno += item.Funcion.Sala.TipoSala.Precio;
            }
            return retorno;
        }

        public IActionResult ElegirMesRecaudacion(string mensaje)
        {
            if(mensaje != null)
            {
                ModelState.AddModelError("", mensaje);
            }
            return View();
        }

        [HttpPost]
        public IActionResult MostrarRecaudacion(MesVM model)
        {
            var reservas = _context.Reservas.Where(r => r.Funcion.Fecha.Month == model.Fecha.Month)
                                            .Include(r => r.Funcion.Sala.TipoSala)
                                            .Include(r => r.Funcion.Pelicula)
                                            .ToList();
            if (reservas.Count == 0)
            {
                return RedirectToAction("ElegirMesRecaudacion", new { mensaje = "No hay reservas en el mes seleccionado"});
            }
            string mes = model.Fecha.ToString("MMMM");
            ViewData["Mes"] = mes;
            foreach (var item in reservas)
            {
                if(item.Funcion.Fecha < DateTime.Now)
                {
                    item.Recaudacion = item.CantidadButacas * item.Funcion.Sala.TipoSala.Precio;
                }
            }
            return View(reservas);
        }

       
    }
}

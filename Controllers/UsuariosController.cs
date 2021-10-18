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
    //[Authorize]
    [Authorize(Roles = "Empleado, Cliente")]
    public class UsuariosController : Controller
    {
        private readonly MiContexto _context;

        public UsuariosController(MiContexto context)
        {
            _context = context;
        }
               
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        //[Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        //[Authorize(Roles = "Administrador")]
        public IActionResult Create()
        {            
            return RedirectToAction("Create", "CuentaCliente");
        }

        //NO SE USA PORQUE EL CONTROLADOR REGISTRO SE ENCARGA
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Nombre,Apellido,Password,DNI,Telefono,FechaAlta,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(usuario);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(usuario);
        //}

        //[Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        //[Authorize(Roles = "Administrador")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nombre,Apellido,Password,DNI,Telefono,FechaAlta,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            return View(usuario);
        }

        //[Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        //[Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

        public IActionResult MostrarDatos()
        {           
            var usuario = _context.Usuarios.Include(u => u.Direccion).FirstOrDefault(u => u.NormalizedEmail == User.Identity.Name.ToUpper());
            var direccion = usuario.Direccion;

            if(usuario.Nombre == null || usuario.Apellido == null || usuario.DNI == null || usuario.Telefono == 0)
            {
                return RedirectToAction("Create", "Registro", new { idUsuario = usuario.Id });
            }

            if(usuario == null)
            {
                return NotFound();
            }

            if(direccion == null)
            {
                return RedirectToAction("Create", "Direcciones", new { idUsuario = usuario.Id });
            }

            return View(usuario);
        }

        public IActionResult ActualizarTelefono(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }
            return View(new ActualizarTelefonoVM { Telefono = usuario.Telefono });
        }

        [HttpPost]
        public IActionResult ActualizarTelefono(ActualizarTelefonoVM model)
        {
            var usuario = _context.Usuarios.Include(c => c.Direccion).FirstOrDefault(c => c.NormalizedEmail == User.Identity.Name.ToUpper());
            usuario.Telefono = model.Telefono;
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();

            return RedirectToAction("MostrarDatos", "Usuarios");

        }
    }
}

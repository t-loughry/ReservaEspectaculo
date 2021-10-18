using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ReservaEspectaculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaEspectaculo.Data
{
    public class DbInicializador
    {
        private const string adminname = "admin@ort.edu.ar";
        private const string passwordDefault = "Password1!";       
        private const string rolAdmin = "Empleado";
        private const string rolCliente = "Cliente";

        public static void Inicializar(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var miContexto = serviceScope.ServiceProvider.GetService<MiContexto>();

                miContexto.Database.EnsureCreated();

                var _usermgr = serviceScope.ServiceProvider.GetService<UserManager<Usuario>>();
                var _rolmgr = serviceScope.ServiceProvider.GetService<RoleManager<Rol>>();

                var roles = miContexto.Rol.ToList();

                if(roles.Count <= 0)
                {
                    var rol1 = _rolmgr.CreateAsync(new Rol { Name = "Cliente" }).Result;                   
                    var rol3 = _rolmgr.CreateAsync(new Rol { Name = "Empleado" }).Result;
                }

                var peli = miContexto.Peliculas.ToList();

                Pelicula pelicula1 = null;
                Pelicula pelicula2 = null;

                if (peli.Count <= 0)
                {

                    Genero genero1 = new Genero { Nombre = "Comedia" };
                    Genero genero2 = new Genero { Nombre = "Accion" };

                    miContexto.Generos.Add(genero1);
                    miContexto.Generos.Add(genero2);

                    pelicula1 = new Pelicula()
                    {
                        Titulo = "Mi pobre angelito",
                        Descripcion = "Un niño se queda solo en navidad",
                        Genero = genero1,
                        Foto = "SinFoto",
                        FechaLanzamiento = new DateTime(1991, 1, 10)
                    };


                    pelicula2 = new Pelicula()
                    {
                        Titulo = "Depredador",
                        Descripcion = "Un furtivo monstruo alienígena ataca a varios comandos durante una misión en las selvas de América Central.",
                        Foto = "SinFoto",
                        Genero = genero2,
                        FechaLanzamiento = new DateTime(1987, 8, 18)
                    };

                    miContexto.Peliculas.Add(pelicula1);
                    miContexto.Peliculas.Add(pelicula2);
                }

                var sala = miContexto.Salas.ToList();

                TipoSala normal = null;
                TipoSala premium = null;
                Sala sala1 = null;
                Sala sala2 = null;

                if (sala.Count <= 0)
                {
                    normal = new TipoSala()
                    {
                        Nombre = "Normal",
                        Precio = 900
                    };

                    premium = new TipoSala()
                    {
                        Nombre = "Premium",
                        Precio = 3900
                    };

                    miContexto.TipoSala.Add(normal);
                    miContexto.TipoSala.Add(premium);

                    sala1 = new Sala()
                    {
                        Numero = 918,
                        TipoSala = normal,
                        CapacidadButacas = 250

                    };

                    sala2 = new Sala()
                    {
                        Numero = 919,
                        TipoSala = premium,
                        CapacidadButacas = 250

                    };

                    miContexto.Salas.Add(sala1);
                    miContexto.Salas.Add(sala2);
                }

                var funciones = miContexto.Funciones.ToList();

                Funcion funcion1 = null;
                Funcion funcion2 = null;
                Funcion funcion3 = null;
                Funcion funcion4 = null;

                if (funciones.Count <= 0)
                {
                    funcion1 = new Funcion()
                    {
                        Fecha = DateTime.Today.AddDays(2),
                        Hora = DateTime.Now.AddHours(3),
                        Descripcion = "Una pelicula para toda la familia",
                        ButacasDisponibles = 245,
                        Confirmada = true,
                        Pelicula = pelicula1,//mi pobre angelito
                        Sala = sala1
                    };

                    funcion2 = new Funcion()
                    {
                        Fecha = DateTime.Today.AddDays(1),
                        Hora = DateTime.Now.AddHours(3),
                        Descripcion = "Una pelicula para pocos...",
                        ButacasDisponibles = 250,
                        Confirmada = true,
                        Pelicula = pelicula2,//depredador
                        Sala = sala2
                    };

                    funcion3 = new Funcion()
                    {
                        Fecha = DateTime.Today.AddDays(-8),
                        Hora = DateTime.Now,
                        Descripcion = "Una pelicula para pocos...",
                        ButacasDisponibles = 245,
                        Confirmada = true,
                        Pelicula = pelicula2,//depredador
                        Sala = sala2
                    };

                    funcion4 = new Funcion()
                    {
                        Fecha = DateTime.Today.AddDays(8),
                        Hora = DateTime.Now.AddHours(3),
                        Descripcion = "Una pelicula para pocos...",
                        ButacasDisponibles = 250,
                        Confirmada = true,
                        Pelicula = pelicula2,//depredador
                        Sala = sala2
                    };

                    miContexto.Funciones.Add(funcion1);
                    miContexto.Funciones.Add(funcion2);
                    miContexto.Funciones.Add(funcion3);
                    miContexto.Funciones.Add(funcion4);
                }

               
                if (!miContexto.Usuarios.Any(u => u.UserName == adminname))
                {
                    var user = new Empleado()
                    {
                        UserName = adminname,
                        NormalizedUserName = adminname.ToUpper(),
                        Email = adminname,
                        NormalizedEmail = adminname.ToUpper(),
                        Nombre = "Empleado",
                        Apellido = "Apellido",
                        Telefono = 112121,
                        DNI = "312121"
                    };

                    var cliente = new Cliente()
                    {
                        Nombre = "Cliente",
                        Apellido = "Apellido",
                        DNI = "13121",
                        Email = "cliente@ort.com",
                        NormalizedEmail = "cliente@ort.com".ToUpper(),
                        Password = "Password1!",
                        UserName = "cliente@ort.com",
                        NormalizedUserName = "cliente@ort.com".ToUpper(),
                        Telefono = 131212                      

                    };

                  var resultado2 = _usermgr.CreateAsync(cliente, passwordDefault).Result;

                    Direccion dir = new Direccion()
                   {
                            Calle = "Calle",
                            Altura = 11212,
                            Localidad = "Localidad",
                            Provincia = "Provincia",
                            UsuarioId = cliente.Id,
                            Usuario = cliente
                   };

                    Direccion dir2 = new Direccion()
                    {
                        Calle = "Empleado",
                        Altura = 11212,
                        Localidad = "Empleado",
                        Provincia = "Empleado",
                        UsuarioId = user.Id,
                        Usuario = user
                    };


                    var resultado = _usermgr.CreateAsync(user, passwordDefault).Result;                                      

                    miContexto.Direcciones.Add(dir);
                    miContexto.Direcciones.Add(dir2);

                    Reserva reserva = new Reserva()
                    {
                        ClienteId = cliente.Id,
                        FechaAlta = funcion1.Fecha.AddDays(-2),
                        ReservaActiva = true,
                        FuncionId = funcion1.FuncionId,
                        CantidadButacas = 5,                        
                       
                    };

                    Reserva reserva2 = new Reserva()
                    {
                        ClienteId = cliente.Id,
                        FechaAlta = funcion3.Fecha.AddDays(-2),
                        ReservaActiva = false,
                        FuncionId = funcion3.FuncionId,
                        CantidadButacas = 5,

                    };

                    miContexto.Reservas.Add(reserva);
                    miContexto.Reservas.Add(reserva2);

                    if (!_rolmgr.RoleExistsAsync(rolAdmin).Result)
                    {
                        var rol = _rolmgr.CreateAsync(new Rol { Name = rolAdmin }).Result;

                    }

                    if (!_rolmgr.RoleExistsAsync(rolCliente).Result)
                    {
                        var rol = _rolmgr.CreateAsync(new Rol { Name = rolCliente }).Result;
                    }                  

                    var usuarioAdministrador = _usermgr.FindByNameAsync(adminname).Result;
                    var usuarioRol = _usermgr.AddToRolesAsync(usuarioAdministrador, new string[] { rolAdmin }).Result;

                    var usuarioCliente = _usermgr.FindByNameAsync("cliente@ort.com").Result;
                    var usuarioRolC = _usermgr.AddToRolesAsync(usuarioCliente, new string[] { rolCliente }).Result;


                    miContexto.SaveChanges();
                }
            }
        }
    }
}

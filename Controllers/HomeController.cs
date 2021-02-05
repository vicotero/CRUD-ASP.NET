using Microsoft.AspNetCore.Mvc;
using Semhan.Models;
using Semhan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semhan.Controllers
{
    public class HomeController : Controller
    {
        public async Task <IActionResult> Index()
        {

            List<UsuarioSet> usuarios = new List<UsuarioSet>(); //usuarios lista vacia
            try
            {
               usuarios = await UsuarioSet.ObtenerUsuarios(new clientesContext());
                
            }
            catch(Exception e)
            {

            }
            return View(usuarios); //retorna lista usuarios

        }

        public async Task<IActionResult> crearUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> crearUsuarioPost([FromBody]UsuarioSet usuarioAlta)
        {
            clientesContext db = new clientesContext();
            UsuarioSet nuevoUsuario = new UsuarioSet
            {
                nombre = usuarioAlta.nombre,
                apellido = usuarioAlta.apellido
            };

            db.UsuarioSet.Add(nuevoUsuario);
            await db.SaveChangesAsync();

            return Json(new {succes = true });
        }

        public async Task<IActionResult> eliminarUsuario(int usuarioId)
        {
            try
            {
                clientesContext db = new clientesContext();
                var usuario = UsuarioSet.ObtenerUsuarioPorId(db, usuarioId).Result;
                db.UsuarioSet.Remove(usuario);
                await db.SaveChangesAsync();

            }
            catch
            {

            }
            return Redirect("Index");
        }

        public async Task<IActionResult> editarUsuario(int usuarioId)
        {
            clientesContext db = new clientesContext();
            var usuario = UsuarioSet.ObtenerUsuarioPorId(db,usuarioId).Result;
            UsuarioSet datosUsuario = new UsuarioSet
            {
                id = usuarioId,
                nombre = usuario.nombre,
                apellido = usuario.apellido

            };
            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> editarUsuario(UsuarioEdicionViewModel usuarioEditado)
        {
            clientesContext db = new clientesContext();
            var usuario = UsuarioSet.ObtenerUsuarioPorId(db, usuarioEditado.id).Result;
            usuario.nombre = usuarioEditado.nombre;
            usuario.apellido = usuarioEditado.apellido;

            db.Update(usuario);
            await db.SaveChangesAsync();

            return Redirect("Index");
        }
    



    }
}

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
            return View();
        }

    }
}

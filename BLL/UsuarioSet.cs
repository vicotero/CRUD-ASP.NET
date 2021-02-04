using Microsoft.EntityFrameworkCore;
using Semhan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semhan
{
    public partial class UsuarioSet
    {
        public static async Task<List<UsuarioSet>> ObtenerUsuarios(clientesContext db)
        {
            return await db.UsuarioSet.ToListAsync(); //retorna una lista de usuariosset , await no siga de largo, espere a que traiga todo

        }

        public static async Task<UsuarioSet> ObtenerUsuarioPorId (clientesContext db, int usuarioId)
        {
            return await db.UsuarioSet.Where(x => x.id == usuarioId).FirstOrDefaultAsync();

        }

    }

   
}

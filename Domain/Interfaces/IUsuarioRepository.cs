using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario ObtenerPorId(int id);
        Usuario ObtenerPorEmail(string email);
        List<Usuario> ObtenerTodos();
        void Crear(Usuario usuario);
        void Actualizar(Usuario usuario);
        void Eliminar(int id);
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICanchaRepository
    {
        Cancha ObtenerPorId(int id);
        List<Cancha> ObtenerPorClubId(int clubId);
        List<Cancha> ObtenerTodas();
        void Crear(Cancha cancha);
        void Actualizar(Cancha cancha);
        void Eliminar(int id);
    }
}

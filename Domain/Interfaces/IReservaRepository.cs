using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IReservaRepository
    {
        Reserva ObtenerPorId(int id);
        List<Reserva> ObtenerPorUsuarioId(int usuarioId);
        List<Reserva> ObtenerPorCanchaId(int canchaId);
        void Crear(Reserva reserva);
        void Actualizar(Reserva reserva);
        void Eliminar(int id);
    }
}

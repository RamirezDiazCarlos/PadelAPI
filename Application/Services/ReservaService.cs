using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public Reserva ObtenerReservaPorId(int id)
        {
            return _reservaRepository.ObtenerPorId(id);
        }

        public List<Reserva> ObtenerReservasPorUsuarioId(int usuarioId)
        {
            return _reservaRepository.ObtenerPorUsuarioId(usuarioId);
        }

        public List<Reserva> ObtenerReservasPorCanchaId(int canchaId)
        {
            return _reservaRepository.ObtenerPorCanchaId(canchaId);
        }

        public void CrearReserva(Reserva reserva)
        {
            _reservaRepository.Crear(reserva);
        }

        public void ActualizarReserva(Reserva reserva)
        {
            _reservaRepository.Actualizar(reserva);
        }

        public void EliminarReserva(int id)
        {
            _reservaRepository.Eliminar(id);
        }
    }
}

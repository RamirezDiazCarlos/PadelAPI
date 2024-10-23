
namespace Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int CanchaId { get; set; }
        public Cancha Cancha { get; set; }
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }
    }
}


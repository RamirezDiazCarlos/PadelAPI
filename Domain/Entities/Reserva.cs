
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int CanchaId { get; set; }
        public virtual Cancha Cancha { get; set; }

        public int TurnoId { get; set; }
        public virtual Turno Turno { get; set; }
    }
}


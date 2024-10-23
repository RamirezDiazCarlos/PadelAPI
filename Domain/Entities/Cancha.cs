
namespace Domain.Entities
{
    public class Cancha
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public List<Turno> Turnos { get; set; } = new List<Turno>();
    }
}


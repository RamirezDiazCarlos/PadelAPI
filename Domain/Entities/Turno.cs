using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Turno
    {
        public int Id { get; set; }
        public string BloqueReserva { get; set; }
        public string Horario { get; set; }
        public int Cupo { get; set; }
        public bool Disponible { get; set; }
        public int CanchaId { get; set; }
        public Cancha Cancha { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CVU { get; set; }
        public string Email { get; set; }
        public int NumeroDeCanchas { get; set; }
        public List<Cancha> Canchas { get; set; } = new List<Cancha>();
    }
}


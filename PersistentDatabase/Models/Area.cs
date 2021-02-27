using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentDatabase.Models
{
    public class Area
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        public Piso Piso { get; set; }
        public string PisoId { get; set; }
    }
}

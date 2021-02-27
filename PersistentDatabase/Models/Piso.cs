using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentDatabase.Models
{
    public class Piso
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Edificio Edificio { get; set; }
        public int EdificioId { get; set; }
        public List<Area> Areas { get; set; }
    }
}

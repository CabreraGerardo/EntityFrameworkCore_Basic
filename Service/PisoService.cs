using PersistentDatabase;
using PersistentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class PisoService
    {
        public void Add(Piso model)
        {
            using (var cn = new AplicationDatabaseContext())
            {
                cn.Add(model);

                cn.SaveChanges();
            }
        }

        public Piso Get(string id)
        {
            using (var cn = new AplicationDatabaseContext())
            {
                return cn.Pisos.Single(x => x.Id == id);
            }
        }
    }
}

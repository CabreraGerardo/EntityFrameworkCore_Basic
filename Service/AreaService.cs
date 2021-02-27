using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersistentDatabase;
using PersistentDatabase.Models;

namespace Service
{
    public class AreaService
    {
        public void Add(Area model)
        {
            using (var cn = new AplicationDatabaseContext())
            {
                cn.Add(model);

                cn.SaveChanges();
            }
        }

        public Area Get(string id)
        {
            using (var cn = new AplicationDatabaseContext())
            {
                return cn.Areas.Single(x => x.Id == id);
            }
        }
    }
}

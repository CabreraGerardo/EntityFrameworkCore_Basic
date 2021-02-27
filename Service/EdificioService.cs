using PersistentDatabase;
using PersistentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class EdificioService
    {
        public Edificio Get(string id)
        {
            using (var cn = new AplicationDatabaseContext())
            {
                return cn.Edificios.Single(x => x.Id == id);
            }
        }
    }
}

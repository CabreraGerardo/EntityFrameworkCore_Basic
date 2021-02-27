using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersistentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentDatabase.Config
{
    public class AreaConfiguration
    {
        public AreaConfiguration(EntityTypeBuilder<Area> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            entityBuilder.Property(x => x.Ubicacion).HasMaxLength(100).IsRequired();
        }
    }
}

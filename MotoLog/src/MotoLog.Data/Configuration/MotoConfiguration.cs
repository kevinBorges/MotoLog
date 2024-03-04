using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotoLog.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Data.Configuration
{
    public class MotoConfiguration : IEntityTypeConfiguration<Moto>
    {
        public void Configure(EntityTypeBuilder<Moto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Plate)
                .IsRequired()
                .HasColumnType("varchar(7)");


            builder.Property(x => x.Year)
                .IsRequired()
                .HasColumnType("varchar(4)");

            builder.ToTable("Motos");
        }
    }
}

using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaHD).HasColumnName("MaHD").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.NgayTaoHD).HasColumnName("NgayTaoHD").HasColumnType("datetime").IsRequired();

            builder.HasOne(p => p.ChiTietPhieuThue).WithOne(p => p.HoaDon).HasForeignKey<HoaDon>(p => p.IdCTPhieuThue);
        }
    }
}

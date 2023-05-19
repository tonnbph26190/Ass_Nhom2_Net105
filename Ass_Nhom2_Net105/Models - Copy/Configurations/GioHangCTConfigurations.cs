using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class GioHangCTConfigurations : IEntityTypeConfiguration<GioHangCT>
	{
		public void Configure(EntityTypeBuilder<GioHangCT> builder)
		{
			builder.ToTable(nameof(GioHangCT));

			builder.HasKey(c => c.IDGHCT);
			builder.Property(c => c.Gia).HasColumnType("decimal").IsRequired();
			builder.Property(c => c.SoLuong).HasColumnType("int").IsRequired();

			builder.HasOne(c => c.SanPhamCT).WithMany(c => c.GioHangCT).HasForeignKey(c => c.IDSPCT);
			builder.HasOne(c => c.GioHang).WithMany(c => c.GioHangcts).HasForeignKey(c => c.IDGH);
		}
	}
}

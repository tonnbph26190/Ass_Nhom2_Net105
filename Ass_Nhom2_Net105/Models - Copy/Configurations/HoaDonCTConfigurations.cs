using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class HoaDonCTConfigurations : IEntityTypeConfiguration<HoaDonCT>
	{
		public void Configure(EntityTypeBuilder<HoaDonCT> builder)
		{
			builder.ToTable("HoaDonCT");
			builder.HasKey(c => c.IDHDCT);
			builder.Property(c => c.Gia).HasColumnType("decimal").IsRequired();
			builder.Property(c => c.SoLuong).HasColumnType("int").IsRequired();

			builder.HasOne(c => c.HoaDon).WithMany(c => c.HoaDonCTs).HasForeignKey(c => c.IDHD);
			builder.HasOne(c => c.SanPhamct).WithMany(c => c.HoaDonCT).HasForeignKey(c => c.IDSPCT);
		}
	}
}

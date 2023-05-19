using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class GioHangConfigurations : IEntityTypeConfiguration<GioHang>
	{
		public void Configure(EntityTypeBuilder<GioHang> builder)
		{
			builder.ToTable(nameof(GioHang));
			builder.HasKey(c => c.IDGioHang);

			builder.HasOne(c => c.NguoiDung).WithMany(c => c.GioHangs).HasForeignKey(c => c.IDGioHang);
		}
	}
}

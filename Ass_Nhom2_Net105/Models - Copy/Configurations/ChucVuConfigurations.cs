using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class ChucVuConfigurations : IEntityTypeConfiguration<ChucVu>
	{
		public void Configure(EntityTypeBuilder<ChucVu> builder)
		{
			builder.ToTable(nameof(ChucVu));
			builder.HasKey(c => c.IDRole);
			builder.Property(c => c.TenChucVu).HasColumnType("nvarchar(25)").IsRequired();
			builder.Property(c => c.MoTa).HasColumnType("nvarchar(100)").IsRequired();
			builder.Property(c => c.TrangThai).HasColumnType("int").IsRequired();

		}
	}
}

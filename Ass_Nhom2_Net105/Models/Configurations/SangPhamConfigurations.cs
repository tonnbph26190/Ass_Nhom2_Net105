using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class SangPhamConfigurations : IEntityTypeConfiguration<SanPham>
	{
		public void Configure(EntityTypeBuilder<SanPham> builder)
		{
			builder.ToTable(nameof(SanPham));
			builder.HasKey(c => c.IdSP);
			builder.Property(c => c.TenSP).HasColumnType("nvarchar(100)").IsRequired();
		}
	}
}

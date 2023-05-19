using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class HangSXConfigurations : IEntityTypeConfiguration<HangSX>
	{
		public void Configure(EntityTypeBuilder<HangSX> builder)
		{
			builder.ToTable(nameof(HangSX));
			builder.HasKey(c => c.IDHangSx);
			builder.Property(c => c.TenHangSX).HasColumnType("nvarchar(1000)").IsRequired();
		}
	}
}

using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class TheLoaiConfigurations : IEntityTypeConfiguration<TheLoai>
	{
		public void Configure(EntityTypeBuilder<TheLoai> builder)
		{
			builder.ToTable(nameof(TheLoai));
			builder.HasKey(c => c.IDTheLoai);
			builder.Property(c => c.TenTheLoai).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(c => c.MoTa).HasColumnType("nvarchar(1000)").IsRequired();
		}
	}
}

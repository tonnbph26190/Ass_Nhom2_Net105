using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class MauConfigurations : IEntityTypeConfiguration<Mau>
	{
		public void Configure(EntityTypeBuilder<Mau> builder)
		{
			builder.ToTable(nameof(Mau));
			builder.HasKey(c => c.IDMau);
			builder.Property(c => c.MauSac).HasColumnType("nvarchar(30)").IsRequired();
		}
	}
}

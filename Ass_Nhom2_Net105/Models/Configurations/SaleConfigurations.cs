using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class SaleConfigurations : IEntityTypeConfiguration<Sale>
	{
		public void Configure(EntityTypeBuilder<Sale> builder)
		{
			builder.ToTable("Sale");
			builder.HasKey(c => c.IDSale);
			builder.Property(c => c.MaSale).HasColumnType("varchar(10)").IsRequired();
			builder.Property(c => c.NgayBatDau).HasColumnType("DateTime").IsRequired();
			builder.Property(c => c.NgayKetThuc).HasColumnType("DateTime").IsRequired();
			builder.Property(c => c.GiaTriSale).HasColumnType("int").IsRequired();
			builder.Property(c => c.TrangThai).HasColumnType("int").IsRequired();
		}
	}

}

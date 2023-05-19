using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class VoucherConfigurations : IEntityTypeConfiguration<Voucher>
	{
		public void Configure(EntityTypeBuilder<Voucher> builder)
		{
			builder.ToTable(nameof(Voucher));
			builder.HasKey(c => c.IDVoucher);
			builder.Property(c => c.MaVoucher).HasColumnType("varchar(10)").IsRequired();
			builder.Property(c => c.NgayTao).HasColumnType("DateTime").IsRequired();
			builder.Property(c => c.Dieukien).HasColumnType("decimal").IsRequired();
			builder.Property(c => c.NgayBatDau).HasColumnType("DateTime").IsRequired();
			builder.Property(c => c.NgayKetThuc).HasColumnType("DateTime").IsRequired();
			builder.Property(c => c.GiaTriVoucher).HasColumnType("decimal").IsRequired();
			builder.Property(c => c.Soluong).HasColumnType("int").IsRequired();
			builder.Property(c => c.TrangThai).HasColumnType("int").IsRequired();
		}
	}
}

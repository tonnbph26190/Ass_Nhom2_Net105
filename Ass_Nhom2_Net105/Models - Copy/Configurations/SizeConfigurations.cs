﻿using DuAn_Net105.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAn_Net105.Models.Configurations
{
	public class SizeConfigurations : IEntityTypeConfiguration<Size>
	{
		public void Configure(EntityTypeBuilder<Size> builder)
		{
			builder.ToTable(nameof(Size));
			builder.HasKey(c => c.IDSize);
			builder.Property(c => c.SizeGiay).HasColumnType("decimal").IsRequired();
		}
	}
}

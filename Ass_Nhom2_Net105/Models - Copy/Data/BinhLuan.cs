namespace DuAn_Net105.Models.Data
{
	public class BinhLuan
	{
		public Guid IDBinhLuan { get; set; }
		public Guid IDSPCT { get ; set; }
		public Guid IDNguoiDung { get; set; }
		public string NoiDung { get; set; }
		public DateTime NgayBinh { get; set; }

		public virtual SanPhamCT SanPhamCT { get; set; }
		public virtual NguoiDung NguoiDung { get; set ; }

	}
}

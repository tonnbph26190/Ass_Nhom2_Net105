namespace DuAn_Net105.Models.Data
{
	public class NguoiDung
	{
		public Guid IDUser { get; set; }
		public Guid IDRole { get; set; }
		public string TenKhachHang { get; set; }
		public string SDT { get; set; }
		public int Email { get; set; }
		public string MatKhau { get; set; }
		public string DiaChi { get; set; }
		public int TrangThai { get; set; }

		public virtual ChucVu ChucVu { get; set; }

		public virtual IEnumerable<HoaDon> HoaDons { get; set; }
		public virtual IEnumerable<GioHang> GioHangs { get; set;}
		public virtual IEnumerable<BinhLuan> BinhLuans { get; set;}
	}
}

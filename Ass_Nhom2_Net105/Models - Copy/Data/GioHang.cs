namespace DuAn_Net105.Models.Data
{
	public class GioHang
	{
		public Guid IDGioHang { get; set; }
		public string Description { get; set; }
		public virtual NguoiDung NguoiDung { get; set; }

		public virtual IEnumerable<GioHangCT> GioHangcts { get; set; }
	}
}

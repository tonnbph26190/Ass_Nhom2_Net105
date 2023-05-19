using NuGet.Packaging.Signing;

namespace DuAn_Net105.Models.Data
{
	public class GioHangCT
	{
		public Guid IDGHCT { get; set; }
		public Guid IDGH { get; set; }
		public Guid IDSPCT { get; set; }
		public decimal Gia { get; set; }
		public int SoLuong { get; set; }

		public virtual GioHang GioHang { get; set; }
		public virtual SanPhamCT SanPhamCT { get; set; }
	}
}

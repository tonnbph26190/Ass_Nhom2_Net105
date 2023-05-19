namespace DuAn_Net105.Models.Data
{
	public class SanPham
	{
		public Guid IdSP { get; set; }
		public string TenSP { get; set; }
		public virtual IEnumerable<SanPhamCT> SanPhamct { get; set; }
	}
}

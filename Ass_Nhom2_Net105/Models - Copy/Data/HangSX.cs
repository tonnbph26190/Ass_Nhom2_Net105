namespace DuAn_Net105.Models.Data
{
	public class HangSX
	{
		public Guid IDHangSx { get; set; }
		public string TenHangSX { get; set; }
		
		public virtual IEnumerable<SanPhamCT> SanPhamCT { get; set; }

	}
	
}

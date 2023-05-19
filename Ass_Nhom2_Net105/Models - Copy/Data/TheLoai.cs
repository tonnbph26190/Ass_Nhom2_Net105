namespace DuAn_Net105.Models.Data
{
	public class TheLoai
	{
		public Guid IDTheLoai { get; set; }
		public string TenTheLoai { get; set; }
		public string MoTa { get ; set; }
		public virtual IEnumerable<SanPhamCT> SanPhamct { get; set;}
	}
}

namespace DuAn_Net105.Models.Data
{
	public class Size
	{
		public Guid IDSize { get; set; }
		public decimal SizeGiay { get; set; }
		public virtual IEnumerable<SanPhamCT> SanPhamct { get; set;}
	}
}

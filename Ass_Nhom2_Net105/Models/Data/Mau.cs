namespace DuAn_Net105.Models.Data
{
	public class Mau
	{
		public Guid IDMau { get; set; }
		public string MauSac { get ; set; }
		public virtual IEnumerable<SanPhamCT> SanPhamct { get; set;}
	}
}

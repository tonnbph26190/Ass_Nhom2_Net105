namespace DuAn_Net105.Models.Data
{
	public class Sale
	{
		public Guid IDSale { get; set; }
		public string MaSale { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public int GiaTriSale { get; set; }
		public int TrangThai { get; set; }

		public virtual IEnumerable<SanPhamCT> SanPhamCT { get; set; }
	}
}

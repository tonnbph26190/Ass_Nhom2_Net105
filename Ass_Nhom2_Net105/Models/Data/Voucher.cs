namespace DuAn_Net105.Models.Data
{
	public class Voucher
	{
		public Guid IDVoucher { get; set; }
		public string MaVoucher { get; set; }
		public DateTime NgayTao { get; set; }
		public decimal Dieukien { get ; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get ; set; }
		public decimal GiaTriVoucher { get; set; }
		public int Soluong { get; set; }
		public int TrangThai { get; set; }

		public virtual IEnumerable<HoaDon> HoaDons { get; set; }
	}
}

using Microsoft.CodeAnalysis.VisualBasic;

namespace DuAn_Net105.Models.Data
{
	public class ChucVu
	{
		public Guid IDRole { get; set; }
		public string TenChucVu { get ; set; }
		public string MoTa { get; set; }
		public int TrangThai { get; set; }
		
		public virtual IEnumerable<NguoiDung> NguoiDung { get; set;}
	}
}

using System.ComponentModel.DataAnnotations;

namespace QuanLyHangHoaAPI.Models
{
    public class HangHoa
    {
        [Key]
        public string MaHang { get; set; }

        public string TenHang { get; set; }

        public string DonViTinh { get; set; }

        public int SoLuongTon { get; set; }

        public double DonGia { get; set; }

        public string MaNCC { get; set; }
    }
}
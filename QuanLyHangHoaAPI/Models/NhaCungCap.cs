using System.ComponentModel.DataAnnotations;

namespace QuanLyHangHoaAPI.Models
{
    public class NhaCungCap
    {
        [Key]
        public string MaNCC { get; set; }

        public string TenNCC { get; set; }

        public string DiaChi { get; set; }

        public string SoDienThoai { get; set; }
    }
}
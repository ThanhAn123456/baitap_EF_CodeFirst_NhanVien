using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace baitap_EF_CodeFirst_NhanVien.Models
{
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaNV { get; set; } = null!;
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}

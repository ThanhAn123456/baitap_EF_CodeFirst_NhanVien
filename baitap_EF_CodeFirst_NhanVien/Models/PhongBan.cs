using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace baitap_EF_CodeFirst_NhanVien.Models
{
    public class PhongBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaPB { get; set; } = null!;
        public string TenPB { get; set; }
        public virtual CongTy CongTy { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}

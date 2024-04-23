using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace baitap_EF_CodeFirst_NhanVien.Models
{
    public class CongTy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaCongTy { get; set; } = null!;
        public string TenCongTy { get; set; }
        public virtual ICollection<PhongBan> PhongBans { get; set; }
    }
}

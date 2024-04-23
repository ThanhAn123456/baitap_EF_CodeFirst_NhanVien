using baitap_EF_CodeFirst_NhanVien.Models;
using Microsoft.EntityFrameworkCore;

namespace baitap_EF_CodeFirst_NhanVien.data_access
{
    public class QuanLyNhanVienCodeFirstDbContext: DbContext
    {
        public QuanLyNhanVienCodeFirstDbContext(DbContextOptions<QuanLyNhanVienCodeFirstDbContext> options) : base(options)
        {

        }
        public QuanLyNhanVienCodeFirstDbContext() { }
        public DbSet<CongTy> CongTy {  get; set; }
        public DbSet<PhongBan> PhongBan { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer("Data Source=AN;Initial Catalog=QuanLyNhanVienCodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }
}

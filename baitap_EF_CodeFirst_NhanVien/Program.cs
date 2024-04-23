
using baitap_EF_CodeFirst_NhanVien.data_access;
using Microsoft.EntityFrameworkCore;

namespace baitap_EF_CodeFirst_NhanVien
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<QuanLyNhanVienCodeFirstDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("QuanLyNhanVienCodeFirstConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            var context = new QuanLyNhanVienCodeFirstDbContext();

            var list = from nv in context.NhanVien
                       join pb in context.PhongBan on nv.PhongBan.MaPB equals pb.MaPB
                       where nv.Tuoi >= 30 && nv.Tuoi <= 40 && pb.MaPB == "PB001"
                             && nv.GioiTinh == "Nam"
                       select new { nv, pb };
            Console.WriteLine("Cac nhan vien co tuoi tu 30 den 40 cua phong marketing la:");
            foreach (var item in list)
            {
                Console.WriteLine($"MaNV: {item.nv.MaNV}, Ten: {item.nv.TenNV}, Tuoi: {item.nv.Tuoi}, Gioi tinh: {item.nv.GioiTinh}, Phong ban: {item.pb.TenPB}");
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

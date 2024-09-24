using System.ComponentModel.DataAnnotations;

namespace BaikiemTra02.Models
{
    public class LopHoc
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống Tên Lớp Học!")]
        public string TenLopHoc { get; set; }

        [Required(ErrorMessage = "Không được để trống Năm Nhập Học!")]
        public int NamNhapHoc { get; set; }

        [Required(ErrorMessage = "Không được để trống Năm Ra Trường!")]
        public int NamRaTruong { get; set; }

        [Required(ErrorMessage = "Không được để trống Số Lượng Sinh Viên!")]
        public int SoLuongSinhVien { get; set; }
    }
}

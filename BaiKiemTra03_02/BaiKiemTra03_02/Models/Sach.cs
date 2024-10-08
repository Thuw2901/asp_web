using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaiKiemTra03_02.Models
{
    public class Sach
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề sách không được để trống!")]
        [Display(Name = "Tiêu Đề Sách")]
        public string TieuDe { get; set; }

        [Required(ErrorMessage = "Năm xuất bản không được để trống!")]
        [Display(Name = "Năm Xuất Bản")]
        public int NamXuatBan { get; set; }

        [Required]
        public int TacGiaId { get; set; }

        [ForeignKey("TacGiaId")]
        [ValidateNever]
        public TacGia TacGia { get; set; }

        [Required]
        public int TheLoaiId { get; set; }  // Khóa ngoại liên kết với TheLoai

        [ForeignKey("TheLoaiId")]
        [ValidateNever]
        public TheLoai TheLoai { get; set; }  // Đối tượng TheLoai liên kết
    }
}

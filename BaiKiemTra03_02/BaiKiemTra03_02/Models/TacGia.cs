using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_02.Models
{
    public class TacGia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống!")]
        [Display(Name = "Tên Tác Giả")]
        public string TenTacGia { get; set; }

        [Required(ErrorMessage = "Quốc tịch không được để trống!")]
        [Display(Name = "Quốc Tịch")]
        public string QuocTich { get; set; }

        [Required(ErrorMessage = "Năm sinh không được để trống!")]
        [Display(Name = "Năm Sinh")]
        public int NamSinh { get; set; }
    }
}

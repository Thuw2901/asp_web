using System.ComponentModel.DataAnnotations;

namespace Project_A.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Không được để trống Tên Thể Loại!")]
        [StringLength(10, ErrorMessage = "{0} phải có độ dài phải từ {2} đến {1} ký tự.", MinimumLength = 8)]
        [Display(Name="Thể Loại")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không đúng định dạng ngày!")]
        [Display(Name = "Ngày Tạo")]
        public DateTime DateCreated { get; set; }=DateTime.Now;

    }
}

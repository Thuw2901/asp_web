using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project_A.Models
{
    //tạo một model cho kế thừa IdentityUser
    //Chyển DbContex chỉnh tiếp ở data
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string? Address { get; set; }
    }
}

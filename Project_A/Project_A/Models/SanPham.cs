﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Project_A.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public string Price { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public int TheLoaiId { get; set; }
        [ForeignKey("TheLoaiId")]
        [ValidateNever]
        public TheLoai TheLoai { get; set; }
    }
}

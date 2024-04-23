using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DangAnhVu_2180603744_BUOI2.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên sách")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên tác giả")]
        [StringLength(50, ErrorMessage = "Tên sách tối đa chỉ 50 ký tự")]
        public string Author { get; set; }
        [Range(1900, 2024, ErrorMessage = "PublicYear phải nằm trong khoảng từ 1900 đến 2024")]
        public int PublicYear { get; set; }
        public double Price { get; set; }
        public string Cover { get; set; }
    }
}
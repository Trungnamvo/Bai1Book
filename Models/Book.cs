﻿namespace Bai1Book.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ID không được để trống!")]
        public int ID { get; set; }

        [Required(ErrorMessage ="Tiêu đề không được để trống!")]
        [StringLength(100, ErrorMessage ="Tiêu đề không được quá 100 ký tự!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống!")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tên không được để trống!")]
        [StringLength(30, ErrorMessage = "Tên tác giả không được quá 30 ký tự!")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống!")]
        [StringLength(255)]
        public string Images { get; set; }
        [Required(ErrorMessage = "Giá không được để trống!")]
        [Range(1000, 1000000, ErrorMessage ="Giá tiền nằm trong khoảng 1K đến 1M!")]
        public int Price { get; set; }
    }
}

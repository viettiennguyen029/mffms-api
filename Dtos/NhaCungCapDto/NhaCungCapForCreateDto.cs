using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MFFMS.API.Dtos.NhaCungCapDto
{
    public class NhaCungCapForCreateDto : BaseDto
    {
        [Required]
        public string TenNhaCungCap { get; set; }
        [Required]
        public string SoDienThoai { get; set; }
        [Required]
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }

    }
}
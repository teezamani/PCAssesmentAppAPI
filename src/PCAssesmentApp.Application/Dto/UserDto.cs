using PCAssesmentApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssesmentApp.Dto
{
   public class UserDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NS.EMS.Data.Entities
{
    public partial class Dept
    {
        [Required]
        public int DeptId { get; set; }

        [Required]
        [MaxLength(10)]
        public string DeptName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NS.EMS.Data.Entities
{
    public partial class Employee
    {
        [Required]
        public int Eid { get; set; }

        [Required]
        [MaxLength(20)]
        public string EmployeeName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Mobile { get; set; }

        [Required]
        [MaxLength(20)]
        public int? DeptId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Gender { get; set; }
    }
}

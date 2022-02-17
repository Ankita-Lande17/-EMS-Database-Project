using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NS.EMS.Model
{
    public class EmployeeDtModel
    {
        [Key]
        public int EID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public int DeptId { get; set; }  
        public string DeptName { get; set; }


        
       

    }
  
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMvcCURD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="This is required field")]
        [DisplayName("Full Name")]
     
        public string FullName { get; set; }
        [DisplayName("Emp. Code")]

        public string EmpCode { get; set; }
        [DisplayName("Designation")]

        public string Position { get; set; }
        [DisplayName("Office Location")]

        public string OfficeLocation { get; set; }

    }
}

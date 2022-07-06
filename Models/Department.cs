using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesApp.Models
{
    [Table("Department", Schema = "dbo")]
    public class Department
    {
        [Key]      // primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // identity
        [Display(Name = "Department ID")]
        public int DepartmentID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Department Abbreviation")]
        public string DepartmentAbbr { get; set; }
    }
}

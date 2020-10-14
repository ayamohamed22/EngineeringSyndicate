using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.ViewModel
{
    public class Projects
    {
        [Column("ProjectId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int ProjectId { get; set; }

        [Column("Name")]
        public String ProjectName { get; set; }
        public String Location { get; set; }

        [ForeignKey("DeptId")]
        public virtual Departments Departments { get; set; }
    }
}

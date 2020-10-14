using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.ViewModel
{
    public class Departments
    {
        [Column("DeptId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int DeptId { get; set; }

        [Column("Name")]
        [StringLength(50)]
        [Required]
        public String Name { get; set; }

        public int NoOfEngineers { get; set; }

        [DataType("date")]
        public string graduationDate { get; set; }

        [ForeignKey("Ssn")]
        public virtual Engineers Engineers { get; set; }

    }
}

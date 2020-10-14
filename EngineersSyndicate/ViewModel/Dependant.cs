using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.ViewModel
{
    public class Dependant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("Name")]
        public String Name { get; set; }

        [ForeignKey("Ssn")]
        public virtual Engineers Engineers { get; set; }
        public String Relation { get; set; }
        public String Gender { get; set; }
    }
}

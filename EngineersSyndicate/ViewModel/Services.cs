using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.ViewModel
{
    public class Services
    {
        [Column("ServicesId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int ServicesId { get; set; }

        public String Type { get; set; }

        [ForeignKey("Ssn")]
        public virtual Engineers Engineers { get; set; }

    }
}

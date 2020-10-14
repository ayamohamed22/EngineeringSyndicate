using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.ViewModel
{
    public class Engineers_Projects
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Ssn")]
        public virtual Engineers Engineers { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Projects Projects { get; set; }
    }
}

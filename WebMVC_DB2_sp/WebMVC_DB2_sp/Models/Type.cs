using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_DB2_sp.Models
{
    public class Type
    {
        [Key]

        public int TypeId { get; set; }
        public int NrCage { get; set; }

        public string Food { get; set; }

        public string Img { get; set; }
        public virtual List<Animal> Animals { get; set; }
    }
}

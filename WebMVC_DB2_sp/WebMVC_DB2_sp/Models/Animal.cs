using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_DB2_sp.Models
{
    public class Animal
    {
        [Key] 
        public int Id { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        [ForeignKey("TypeId")]
        public int? TypeId { get; set; }
        public virtual Type? Type { get; set; }

    }
}

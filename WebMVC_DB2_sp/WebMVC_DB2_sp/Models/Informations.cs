using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_DB2_sp.Models
{
    public class Informations
    {
        public List<Animal> animals;
        public List<Type> types;

        public Informations()
        {
            this.animals = new List<Animal>();
            this.types = new List<Type>();
        }
    }
}

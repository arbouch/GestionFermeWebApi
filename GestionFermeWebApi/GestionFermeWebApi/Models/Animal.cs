using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestionFermeWebApi.Models
{
    public class Animal
    {
        [Key]
        public int animalId { get; set; }
        public string IdentifiantAnimal { get; set; }
        public string IdentifiantPere { get; set; }
        public string IdentifiantMere { get; set; }
        public string sexe { get; set; }

    }
}

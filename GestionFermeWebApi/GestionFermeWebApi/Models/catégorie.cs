using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestionFermeWebApi.Models
{
    public class categorie
    {
        [Key]
        public int categorieId { get; set; }
        public string categorieLabelle { get; set; }
    }
}

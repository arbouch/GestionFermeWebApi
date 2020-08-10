using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionFermeWebApi.Models
{
    [Table("race")]
    public class RACE
    {
        [Key]
        public int idRace { get; set; }
        public string Designation { get; set; }
        public string Type { get; set; }
    }
}

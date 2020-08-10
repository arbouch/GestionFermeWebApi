using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionFermeWebApi.Models
{
    [Table("veterinaire")]

    public class VETERINAIRE
    {
        [Key]
        public int IDVet { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int  num1 { get; set; }
        public int num2 { get; set; }


    }
}

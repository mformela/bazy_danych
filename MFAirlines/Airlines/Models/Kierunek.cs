using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    class Kierunek
    {
        [Required]
        public int KierunekId { get; set; }

       
        [Required]
        [Column(TypeName = "nchar")]
        [StringLength(50)]
        public int DataOdlotu { get; set; }

        [Required]
        [Column(TypeName = "nchar")]
        [StringLength(50)]
        public int DataPrzylotu { get; set; }

        public ICollection<Lot> Lot { get; set; }
    }
}

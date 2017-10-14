using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    class Lot
    {
        [Required]
        public int LotId { get; set; }

        [Required]
        [Column(TypeName = "nchar")]
        [StringLength(4)]
        public string NrLotu { get; set; }


        
        public int KierunekId { get; set; }
        
        public int SamolotId { get; set; }
        public int ZalogaId { get; set; }

      
        public DateTime DataOdlotu { get; set; }
    
        public DateTime DataPrzylotu { get; set; }
    }

}

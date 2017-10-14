using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    class Zalogant
    {
        [Required]
        public int ZalogantId { get; set; }
        

        [Required]
        [Column(TypeName = "nchar")]
        [StringLength(11)]
        public string PESEL { get; set; }

        [Required]
        public DateTime DataZatrudnienia { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Adres { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(11)]
        public string NrTelefonu { get; set; }

        public int StanowiskokId { get; set; }
        public int ZalogaId { get; set; }
    }
}

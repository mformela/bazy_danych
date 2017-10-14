using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    class Stanowisko
    {

        [Required]
        public int StanowiskoId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Nazwa{ get; set; }

        public ICollection<Zalogant> Zalogant { get; set; }
    }
}

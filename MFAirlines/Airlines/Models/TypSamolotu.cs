using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    class TypSamolotu
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int TypId { get; set; }
        public string Nazwa { get; set; }
        public int IloscMiejsc { get; set; }

        public ICollection<Samolot> Samoloty { get; set; }
    }
}

using BusinessEntities_FrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Models
{
    [Table("Konferens")]
    public class Konferens : IKonferens
    {
        [Key, Column(Order = 0)]
        public int KonferensID { get; set; }
        [Required]
        public string KonferensTyp { get; set; }
        // En av nedan + ovan för att få fram ett pris
        public bool Tillgänglig { get; set; }
        public int Vecka { get; set; }
        public int AntalDagar { get; set; }
        public int Timmar { get; set; }
        public double Pris { get; set; }

        // --
        public Bokning Bokning { get; set; }
        public ICollection<KonferensPris> KonferensPriser { get; set; }
        
    }
}

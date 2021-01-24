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
    [Table("VD")]
    public class VD : IVD, IAnställd
    {
        [Key]
        public int AnställningsID { get; set; }
        public string AnvändarNamn { get; set; }
        public string Lösenord { get; set; }
        public string AnställdFörnamn { get; set; }
        public string AnställdEfternamn { get; set; }
        public string AnställningsTyp { get; set; }
        public string Behörighet { get; set; }

        // Specifik för marknadschef och VDn
        public ICollection<Bokning> PreBokning { get; set; }
    }
}

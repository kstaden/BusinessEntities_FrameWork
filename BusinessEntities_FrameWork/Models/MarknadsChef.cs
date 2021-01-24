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
    [Table("MarknadsChef")]
    public class MarknadsChef : IMarknadsChef, IAnställd
    {
        [Key, Column(Order = 0)]
        public int AnställningsID { get; set; }
        public string AnvändarNamn { get; set; }
        public string Lösenord { get; set; }
        public string AnställdFörnamn { get; set; }
        public string AnställdEfternamn { get; set; }
        public string AnställningsTyp { get; set; }
        public string Behörighet { get; set; }

        // Specifik för marknadschef
        public ICollection<Bokning> PreBokning { get; set; }
    }
}

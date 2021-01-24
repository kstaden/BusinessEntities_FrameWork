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
    [Table("PrivatKund")]
    public class PrivatKund : IPrivatKund
    {
        [Key, Column(Order = 0)]
        public int PrivatKundID { get; set; }
        public string PrivatFörnamn { get; set; }
        public string PrivatEfternamn { get; set; }
        public string PrivatGatuadress { get; set; }
        public string PrivatPostnummer { get; set; }
        public string PrivatPostort { get; set; }
        public string PrivatTelefonnummer { get; set; }
        public string PrivatEpostadress { get; set; }

        // --
        public ICollection<Bokning> Bokningar { get; set; }
        public ICollection<Uthyrning> Uthyrningar { get; set; }
        public virtual ICollection<Faktura> Fakturor { get; set; }
        public ICollection<PreBokning> PreBokningar { get; set; }

        public PrivatKund()
        {
            Fakturor = new List<Faktura>();
            Bokningar = new List<Bokning>();
            PreBokningar = new List<PreBokning>();
        }
    }
}

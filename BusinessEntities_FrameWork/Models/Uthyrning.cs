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
    [Table("Uthyrning")]
    public class Uthyrning : IUthyrning
    {
        [Key, Column(Order = 0)]
        public int UthyrningsID { get; set; }
        public DateTime UthyrningsDatum { get; set; }
        public double UthyrningsPris { get; set; }
        public int AntalDagar { get; set; }
        public Utrustning ArtikelID { get; set; }




        public Anställd Anställd { get; set; }

        public PrivatKund PrivatKund { get; set; }

        public FöretagsKund FöretagsKund { get; set; }

        public TempKund TempKund { get; set; }

        public Faktura Faktura { get; set; }

        // Constructor
        public Uthyrning()
        {
            UtrustningsTillUthyrning = new List<Utrustning>(); 
            //
        }

        public virtual ICollection<Utrustning> UtrustningsTillUthyrning { get; set; }
        public virtual ICollection<Faktura> Fakturor { get; set; }
    }
}

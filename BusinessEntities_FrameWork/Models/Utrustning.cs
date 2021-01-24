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
    [Table("Utrustning")]
    public class Utrustning : IUtrustning
    {
        [Key, Column(Order = 0)]
        public int ArtikelID { get; set; }
        public string UtrustningSort { get; set; } // alpint
        public string UtrustningsTyp { get; set; } // pjäxor

       public bool Tillgänglig { get; set; }

        // Mängd


        // Constructor
        public Utrustning()
        {
            //Uthyrning = new List<Uthyrning>();
            //Hyrpris = new List<Hyrpris>();
        }



        public ICollection<Uthyrning> Uthyrning { get; set; }

        public ICollection<Hyrpris> Hyrpris { get; set; }
    }
}

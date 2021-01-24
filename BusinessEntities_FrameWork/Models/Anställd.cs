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
    [Table("Anställd")]
    public class Anställd : IAnställd
    {
        [Key, Column(Order = 0)]
        public int AnställningsID { get; set; }

        [Required]
        [StringLength(16)]
        public string AnvändarNamn { get; set; }

        [Required]
        [StringLength(20)]
        public string Lösenord { get; set; }

        [Required]
        public string AnställdFörnamn { get; set; }

        public string AnställdEfternamn { get; set; }
        public string AnställningsTyp { get; set; }
        public string Behörighet { get; set; }


        //// --
        public virtual ICollection<Bokning> Bokningar { get; set; }

        public virtual ICollection<Uthyrning> Uthyrningar { get; set; }

        // Constructor
        public Anställd()
        {
            //Uthyrningar = new List<Uthyrning>();
            //Bokningar = new List<Bokning>();
        }
      
    }
}

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
    [Table("TempKund")]
    public class TempKund : ITempKund
    {
        [Key, Column(Order = 0)]
        public int TempKundID { get; set; }
        public string TempKundFörnamn { get; set; }
        public string TempKundEfternamn { get; set; }
        public string TempKundTelefonNummer { get; set; }

        public TempKund()
        {
            
        }

        public ICollection<Bokning> Bokningar { get; set; }
        public ICollection<Uthyrning> Uthyrning { get; set; }
    }
}

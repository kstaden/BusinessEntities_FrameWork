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
    [Table("LogiPris")]
    public class LogiPris : ILogiPris
    {
        [Key, Column(Order = 0)]
        public int LogiPrisID { get; set; }
        public string LogiTyp { get; set; }
        public int Vecka { get; set; }
        public int Dagar { get; set; }
        public Logi LogiID { get; set; }
        public double Pris { get; set; }


        // --
        public ICollection<Logi> Logier { get; set; }

    }
}

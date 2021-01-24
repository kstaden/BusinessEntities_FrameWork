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
    [Table("KonferensPris")]
    public class KonferensPris : IKonferensPris
    {
        [Key, Column(Order = 0)]
        public int KonferensPrisID { get; set; }
        public string TidTyp { get; set; }
        public string KonferensTyp { get; set; }

        public int Vecka { get; set; }


        public double Pris { get; set; }

        // --
        public Konferens Konferens { get; set; }
    }
}

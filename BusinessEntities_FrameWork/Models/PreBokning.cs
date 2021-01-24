using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities_FrameWork.Interfaces;

namespace BusinessEntities_FrameWork.Models
{
    public class PreBokning : IBokning
    {
        [Key, Column(Order = 0)]
        public int BokningsID { get; set; }
        [Required]
        public DateTime InCheckningsDatum { get; set; }
        [Required]
        public DateTime UtCheckningsDatum { get; set; }
        [Required]
        public string BokningsTyp { get; set; }
        public double BokningsPris { get; set; }
        public double Moms { get; set; }
        public double Bruttopris { get; set; }
        public double Nettopris { get; set; }
        public bool Status { get; set; }

        // --
        public Bokning Bokning { get; set; }
        public PrivatKund PrivatKund { get; set; }
        public FöretagsKund FöretagsKund { get; set; }

    }
}

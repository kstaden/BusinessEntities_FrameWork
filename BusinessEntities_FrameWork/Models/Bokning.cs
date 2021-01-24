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
    [Table("Bokning")]
    public class Bokning : IBokning
    {
        [Key, Column(Order = 0)]
        public int BokningsID { get; set; }
        [Required]
        public DateTime InCheckningsDatum { get; set; }
        [Required]
        public DateTime UtCheckningsDatum { get; set; }
        public string BokningsTyp { get; set; }
        public double BokningsPris { get; set; }
        public double Moms { get; set; }
        public double Bruttopris { get; set; }
        public double Nettopris { get; set; }
        public bool Status { get; set; }


        // Constructor
        public Bokning()
        {
            Fakturor = new HashSet<Faktura>();
            PreBokningar = new HashSet<PreBokning>();
            Konferenser = new HashSet<Konferens>();
            LogiBokningar = new HashSet<LogiBokning>();
            BokaSkidLektioner = new List<BokningSkidLektion>();
            UtrustningsLista = new List<Utrustning>();
            LogiTillBokning = new List<Logi>();
            PrivatKund = new PrivatKund();
            //
        }

        // External properies
        public Anställd Anställd { get; set; }
        public PrivatKund PrivatKund { get; set; }
        public FöretagsKund FöretagsKund { get; set; }
        public TempKund TempKund { get; set; }

        public virtual ICollection<Faktura> Fakturor { get; set; }
        public virtual ICollection<PreBokning> PreBokningar { get; set; }
        public virtual ICollection<Konferens> Konferenser { get; set; }
        // Logi eller LogiBokning?
        public virtual ICollection<LogiBokning> LogiBokningar { get; set; }
        public virtual ICollection<BokningSkidLektion> BokaSkidLektioner { get; set; }
        public virtual ICollection<Utrustning> UtrustningsLista { get; set; }
        public virtual ICollection<Logi> LogiTillBokning{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IFöretagsKund
    {
        public int FöretagKundID { get; set; }
        public string Företagsnamn { get; set; }
        public string OrgNummer { get; set; }
        public decimal FöretagRabatt { get; set; }
        public string RefPerson { get; set; }
        public string FöretagTelefonNummer { get; set; }
        public string FöretagEpostadress { get; set; }
        public string Gatuadress { get; set; }
        public string FöretagPostnummer { get; set; }
        public string FöretagPostort { get; set; }
        public string Faktureringsadress { get; set; }
        public string FöretagFaktureringPostnummer { get; set; }
        public string FöretagFaktureringPostort { get; set; }
    }
}

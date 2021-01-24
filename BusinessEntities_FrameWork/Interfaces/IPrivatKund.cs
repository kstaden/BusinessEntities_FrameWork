using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IPrivatKund
    {
        public int PrivatKundID { get; set; }
        public string PrivatFörnamn { get; set; }
        public string PrivatEfternamn { get; set; }
        public string PrivatGatuadress { get; set; }
        public string  PrivatPostnummer { get; set; }
        public string PrivatPostort { get; set; }
        public string PrivatTelefonnummer { get; set; }
        public string PrivatEpostadress { get; set; }

        
    }
}

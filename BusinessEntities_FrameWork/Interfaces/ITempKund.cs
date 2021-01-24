using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface ITempKund
    {
        public int TempKundID { get; set; }
        public string TempKundFörnamn { get; set; }
        public string TempKundEfternamn { get; set; }
        public string TempKundTelefonNummer { get; set; }
    }
}

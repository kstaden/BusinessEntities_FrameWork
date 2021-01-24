using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IAnställd
    {
        public int AnställningsID { get; set; }
        public string AnvändarNamn { get; set; }
        public string Lösenord { get; set; }
        public string AnställdFörnamn { get; set; }
        public string AnställdEfternamn { get; set; }
        public string AnställningsTyp { get; set; }
        public string Behörighet { get; set; }

    }
}

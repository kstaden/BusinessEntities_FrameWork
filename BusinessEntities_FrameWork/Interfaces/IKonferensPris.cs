using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IKonferensPris
    {
        public int KonferensPrisID { get; set; }
        public string TidTyp { get; set; }
        public string KonferensTyp { get; set; }

        public int Vecka { get; set; }
        public double Pris { get; set; }
    }
}

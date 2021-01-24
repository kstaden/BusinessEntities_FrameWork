using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface ILogiPris
    {
        public int LogiPrisID { get; set; }
        public string LogiTyp { get; set; }
        public int Dagar { get; set; }
        public int Vecka { get; set; }
        public double Pris { get; set; }

        public Logi LogiID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IFaktura
    {
        public int FakturaID { get; set; }
        public double Pris { get; set; }
        public DateTime FaktureringsDatum { get; set; }
        public DateTime FörfalloDatum { get; set; }
    }
}

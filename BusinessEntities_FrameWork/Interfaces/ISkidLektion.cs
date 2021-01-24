using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface ISkidLektion
    {
        public int SkidLektionsID { get; set; }
        public string SkidLärare { get; set; }
        public string TypAvLektion { get; set; }

        public double Pris { get; set; }
    }
}

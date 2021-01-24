using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IBokningSkidLektion
    {
        public int SkidLektionsID { get; set; }
        public int BokningsID { get; set; }
    }
}

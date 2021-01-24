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
    [Table("BokningSkidLektion")]
    public class BokningSkidLektion : IBokningSkidLektion
    {
        [Key, Column(Order = 0)]
        public int SkidLektionsID { get; set; }
        public int BokningsID { get; set; }

        // --
        public Bokning Bokning { get; set; }
      
    }
}

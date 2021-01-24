using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IDeltagare
    {
        public int DeltagarID { get; set; }
        public string DeltagarFörnamn { get; set; }
        public string DeltagarEfternamn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Models
{
    public class Privatskidlektion : IPrivatskidlektion
    {
        [Key, Column(Order = 0)]
        public int PrivatskidlektionsID { get; set; }
        public int Antaldeltagare { get; set; }
        public string Lärare { get; set; }

        // --
        public SkidLektion SkidLektion { get; set; }
        public ICollection<Deltagare> PrivatDeltagare { get; set; }
    }
}

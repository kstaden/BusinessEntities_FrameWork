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
    [Table("SysAdmin")]
    public class SysAdmin : ISysAdmin
    {
        [Key, Column(Order = 0)]
        public int SysAdminID { get; set; }
        public string AnvändarNamn { get; set; }
        public string Lösenord { get; set; }
        public string SysAdminFörnamn { get; set; }
        public string SysAdminEfternamn { get; set; }
        public string AnställningsTyp { get; set; }
        public string Behörighet { get; set; }

        // --
        public ICollection<Bokning> Bokningar { get; set; }
        public Anställd Anställd { get; set; }

        //
        public SysAdmin()
        {

        }
    }
}

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
    [Table("Deltagare")]
    public class Deltagare : IDeltagare
    {
        [Key, Column(Order = 0)]
        public int DeltagarID { get; set; }

        public string DeltagarFörnamn { get; set; }

        public string DeltagarEfternamn { get; set; }

        // --
        public Privatskidlektion Privatskidlektion { get; set; }
        public Gruppskidlektion Gruppskidlektion { get; set; }
    }
}

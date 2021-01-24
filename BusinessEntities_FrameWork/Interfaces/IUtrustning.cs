using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IUtrustning
    {
        public int ArtikelID { get; set; }
        public string UtrustningSort { get; set; }
        public string UtrustningsTyp { get; set; }

    }
}

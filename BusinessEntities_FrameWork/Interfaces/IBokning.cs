using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface IBokning
    {
        public int BokningsID { get; set; }
        public DateTime InCheckningsDatum { get; set; }
        public DateTime UtCheckningsDatum { get; set; }
        public string BokningsTyp { get; set; }
        public double BokningsPris { get; set; }
        // Tillägg av attribut
        public double Moms { get; set; }
        public double Bruttopris { get; set; }
        public double Nettopris { get; set; }
        public bool Status { get; set; }
        public PrivatKund PrivatKund { get; set; }
    }
}

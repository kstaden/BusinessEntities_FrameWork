using System.Collections.Generic;

namespace BusinessEntities_FrameWork.Models
{
    public interface IVD
    {
        string AnställdEfternamn { get; set; }
        string AnställdFörnamn { get; set; }
        int AnställningsID { get; set; }
        string AnställningsTyp { get; set; }
        string AnvändarNamn { get; set; }
        string Behörighet { get; set; }
        string Lösenord { get; set; }
        ICollection<Bokning> PreBokning { get; set; }
    }
}
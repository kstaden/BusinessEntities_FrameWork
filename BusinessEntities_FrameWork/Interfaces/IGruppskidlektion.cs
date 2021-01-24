namespace BusinessEntities_FrameWork.Models
{
    public interface IGruppskidlektion
    {
        int Antaldeltagare { get; set; }
        string Färg { get; set; }
        int GruppskidlektionsID { get; set; }
        string Lärare { get; set; }
    }
}
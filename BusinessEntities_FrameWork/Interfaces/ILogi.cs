using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities_FrameWork.Interfaces
{
    public interface ILogi
    {
        public int LogiID { get; set; }
        public string LogiTyp { get; set; }
        public int Dagar { get; set; }
        public int Vecka { get; set; }
        public void UppdateraLogi(Logi NyLogi);
        
    }
}

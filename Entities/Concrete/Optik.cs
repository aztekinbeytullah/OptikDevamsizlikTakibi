using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Optik:IEntity
    {
        public int OptikId { get; set; }
        public int KurumId { get; set; }
        public int SinifId { get; set; }
        public int  Tarih { get; set; }

    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sinif:IEntity
    {
        public int SinifId { get; set; }
        public int KurumId { get; set; }

        public string Ad { get; set; }

        public int Kapasite { get; set; }

    }
}

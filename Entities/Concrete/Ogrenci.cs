using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ogrenci:IEntity
    {
        public int OgrenciId { get; set; }
        public int KurumId { get; set; }
        public int SinifId { get; set; }
        public int OkulNo { get; set; }
        public int Ad { get; set; }
        public int Soyad { get; set; }
        public int Telefon { get; set; }
        public int Email { get; set; }


    }
}

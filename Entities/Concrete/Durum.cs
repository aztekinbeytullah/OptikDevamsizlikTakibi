using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Durum : IEntity
    {
        public int DurumId { get; set; }
        public string Ad { get; set; }

    }
}

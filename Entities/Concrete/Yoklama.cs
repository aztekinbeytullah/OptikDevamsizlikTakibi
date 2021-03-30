using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Yoklama:IEntity
    {
        public int YoklamaId { get; set; }
        public int OptikId { get; set; }

        public int OgrenciId { get; set; }
        public int DurumId { get; set; }
    }
}

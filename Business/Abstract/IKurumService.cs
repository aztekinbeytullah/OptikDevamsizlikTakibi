using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKurumService
    {
        void Ekle(Kurum kurum);
        void Sil(Kurum kurum);
        void Güncelle(Kurum kurum);
    }
}

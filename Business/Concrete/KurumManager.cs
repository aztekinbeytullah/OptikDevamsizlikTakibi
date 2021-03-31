using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KurumManager : IKurumService
    {
        IKurumDal _kurumDal;
        public void Ekle(Kurum kurum)
        {
            _kurumDal.Ekle(kurum);
        }
        public void Güncelle(Kurum kurum)
        {
            _kurumDal.Guncelle(kurum);
                 
        }
        public void Sil(Kurum kurum)
        {
            _kurumDal.Sil(kurum);
        }
    }
}

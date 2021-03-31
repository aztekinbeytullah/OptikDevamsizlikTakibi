using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKurumDal :EfEntityRepositoryBase<Kurum,OptikDevamsizlikContext>,IKurumDal
    {
        
    }
}

using ProductionDll;
using ProductionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductionBll
{
     public partial class ProductInfoBll
    {


        //创建数据层对象
        ProductInfoDll miDal = new ProductInfoDll();


        public List<ProductInfo> GetList(Dictionary<string,string>dic)
        {
            return miDal.GetList(dic);
        }

        public bool Add(ProductInfo mi )
        {
            return miDal.Insert(mi) > 0;
        }

        public bool Edit(ProductInfo mi)
        {
            return miDal.Update(mi) > 0;
        }
        public bool Remove(int id)
        {
            return miDal.Delete(id) > 0;
        }
    }
}

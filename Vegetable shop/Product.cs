using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_15._1.Vegetable_shop
{
    public class Product
    {
        protected int BasePrice;
        public virtual int Price
        {
            get => BasePrice;
            set => BasePrice = value;
        }
    }
}

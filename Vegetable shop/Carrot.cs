using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_15._1.Vegetable_shop
{
    public class Carrot : Product
    {
        private int BasePrice;
        public override int Price => BasePrice;

        public Carrot(int basePrice)
        {
            BasePrice = basePrice;
        }
    }
}

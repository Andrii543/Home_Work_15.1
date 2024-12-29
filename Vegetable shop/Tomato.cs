using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_15._1.Vegetable_shop
{
    public class Tomato : Product
    {
        private int BasePrice;

        public override int Price => BasePrice;
        public Tomato(int price)
        {
            BasePrice = price;
        }
    }
}

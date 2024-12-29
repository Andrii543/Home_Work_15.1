using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_15._1.Vegetable_shop
{
    public class Potato : Product
    {
        private int BasePrice;
        public int Count;

        public override int Price
        {
            get=> BasePrice * Count; 
        }


        public Potato(int price, int count)
        {
            BasePrice = price;
            Count = count;

        }




    }
}

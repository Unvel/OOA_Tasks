using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Coffee
    {
        private double _price;
        private string _orderLine;
        public Coffee(double price, string orderLine)
        {
            _orderLine += orderLine;
            _price = price;
        }

        public virtual double Price()
        {
            return _price;
        }

        public virtual string OrderLine()
        {
            return _orderLine;
        }
    }
}

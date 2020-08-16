using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class StockException : Exception
    {
        public StockException(string message) : base(message)
        {

        }
    }
}

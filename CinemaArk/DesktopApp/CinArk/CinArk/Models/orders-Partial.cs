using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Models
{
    partial class orders
    {
        public orders(int customer_id, System.DateTime date, string payment_mode)
        {
            this.customer_id = customer_id;
            this.date = date;
            this.payment_mode = payment_mode;
        }

        public orders()
        {
            this.customer_id = customer_id;
            this.date = date;
            this.payment_mode = payment_mode;
        }
    }
}

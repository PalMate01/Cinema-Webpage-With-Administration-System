using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Models
{
    partial class items
    {
        public items(int product_id, int quantity, int price, int order_id, int customer_id, string movie, int room, int line, int seat, string month, string day, string lecture)
        {
            this.product_id = product_id;
            this.quantity = quantity;
            this.price = price;
            this.order_id = order_id;
            this.customer_id = customer_id;
            this.movie = movie;
            this.room = room;
            this.line = line;
            this.seat = seat;
            this.month = month;
            this.day = day;
            this.lecture = lecture;
        }

        public items()
        {
            this.product_id = product_id;
            this.quantity = quantity;
            this.price = price;
            this.order_id = order_id;
            this.customer_id = customer_id;
            this.movie = movie;
            this.room = room;
            this.line = line;
            this.seat = seat;
            this.month = month;
            this.day = day;
            this.lecture = lecture;
        }
    }
}

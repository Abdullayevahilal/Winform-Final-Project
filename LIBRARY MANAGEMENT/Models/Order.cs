﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY_MANAGEMENT.Models
{
    //public class OrderBook
    //{
    //    public int İd { get; set; }
    //    public string BookName { get; set; }
    //    public int Days { get; set; }
    //    public DateTime İssueDate { get; set; }
    //    public DateTime ReturnDate { get; set; }
    //    public bool İsAvailable { get; set; }
    //    public int BookId { get; set; }
    //    public int CustomerId { get; set; }
    //    public Book Book { get; set; }
    //    public Customer Customer { get; set; }

    //}
    public class Order
    {
        public int Id { get; set; }
        public DateTime? GivingTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime? DeadLine { get; set; }
        public int? BookCount { get; set; }
        public decimal? LastMoney { get; set; }
        public int? ManagerId { get; set; }
        public int? CustomerId { get; set; }
        public Manager Manager { get; set; }
        public Customer Customer { get; set; }
        public List<OrderBook> OrderBooks { get; set; }

    }


}

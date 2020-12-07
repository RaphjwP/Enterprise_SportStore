using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class OrderListViewModel
    {
        public Order Orders { get; set; }

        public int TotalProduct { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
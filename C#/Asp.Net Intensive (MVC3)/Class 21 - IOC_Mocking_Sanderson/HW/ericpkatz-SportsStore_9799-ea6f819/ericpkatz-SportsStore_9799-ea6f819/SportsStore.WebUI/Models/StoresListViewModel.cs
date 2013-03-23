using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    public class StoresListViewModel
    {
        public IEnumerable<Store> Stores { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
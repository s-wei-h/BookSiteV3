using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int Currentpage { get; set; }
        //get decimal then round up with math.ceiling, then cast to int
        public int TotalPages => (int) (Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}

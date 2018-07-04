using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Web.Models.Setup
{
    public class AuthorListingViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TotalBooks { get; set; }
    }
}

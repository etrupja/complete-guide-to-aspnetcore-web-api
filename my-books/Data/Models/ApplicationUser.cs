using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Custom { get; set; }
    }
}

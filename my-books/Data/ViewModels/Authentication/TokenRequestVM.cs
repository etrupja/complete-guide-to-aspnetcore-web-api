using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels.Authentication
{
    public class TokenRequestVM
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}

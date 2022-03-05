using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_loginIdentityCore5.Model
{
    public class AuthDBConetext :IdentityDbContext
    {
        public AuthDBConetext(DbContextOptions<AuthDBConetext> options ) : base (options)
        {

        }
    }
}

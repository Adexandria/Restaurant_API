using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeResturant_API.Services
{
    public class OwinDbContext :IdentityDbContext
    {
        public OwinDbContext() : base("Identity")
        {

        }
    }
}

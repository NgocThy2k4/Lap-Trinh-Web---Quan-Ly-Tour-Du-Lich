using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web.Identity
{
    public class AppDbcontext : IdentityDbContext<AppUser>
    {
        public AppDbcontext() : base("TourismManage3ConnectionString") { }


        public static AppDbcontext Create()
        {
            return new AppDbcontext();
        }

    }
   
}